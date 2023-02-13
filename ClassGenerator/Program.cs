// See https://aka.ms/new-console-template for more information
using System.Reflection;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

Console.WriteLine("Hello, World!");


var location = Assembly.GetExecutingAssembly().Location;
var path = Path.GetFullPath(Path.Combine(location, @"..\..\..\..\dpdSchema"));

//foreach (var filePath in Directory.GetFiles(path))
//{
    var filePath = Path.Combine(path, "AdditionalCourierServices.schema.json");
    var schemaJson = File.ReadAllText(filePath);

    //schemaJson = schemaJson.Replace("urn:jsonschema:com:dpd:api:rest:services:model:", "");
    schemaJson = schemaJson.Insert(schemaJson.Length - 1, ",\"additionalProperties\": false");

    var schema = JsonSchema.FromJsonAsync(schemaJson,path + "\\AdditionalCourierService.schema.json").Result;
    var newFileName = filePath.Substring(filePath.LastIndexOf("\\") + 1, filePath.IndexOf(".") - filePath.LastIndexOf("\\") - 1);
    schema.Title = newFileName;


    var generator = new CSharpGenerator(schema)
    {
        Settings =
    {
        GenerateDataAnnotations = false,
        RequiredPropertiesMustBeDefined = false,
        EnforceFlagEnums = false,
        ClassStyle = CSharpClassStyle.Poco,
        GenerateNativeRecords = false,
        Namespace = "dpd_api.DpdModels",
        SchemaType = SchemaType.JsonSchema,
        PropertyNameGenerator = new CSharpPropertyNameGenerator{},
    }
    };

    //generator.Settings.Namespace = "dpd_api.DpdModels";
    //generator.Settings.GenerateDataAnnotations = false;
    //generator.Settings.GenerateOptionalPropertiesAsNullable= false;
    //generator.Settings.GenerateJsonMethods = false;
    //generator.Settings.

    var generatedFile = generator.GenerateFile();

    File.WriteAllText(Path.Combine(location, @"..\..\..\..\dpdModels", string.Concat(newFileName,".cs")), generatedFile);
//}