using System.Text.Json;

namespace FileManager.test
{
    public class Serializable
    {
        [Fact]
        public void SerializarJsonDirectorio()
        {
            var d = new DirectoryInfo("Starwars");
            d.Create();

            var options = new JsonSerializerOptions();
            var dJson = JsonSerializer.Serialize(d, options: options);
            Assert.True(true);
        }

        [Fact]
        public void SerializarJsonObjAnonimo()
        {
            var dir = new
            {
                Name = "Starwars",
                Date = DateTime.Now,
            };

            var dataJson = JsonSerializer.Serialize(dir);

            Assert.Equal("Starwars", dir.Name);
        }
    }
}
}