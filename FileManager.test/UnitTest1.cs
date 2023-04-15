namespace FileManager.test
{
    public class UnitTest1
    {
        [Fact]
        public void DirectorioCrear()
        {
            Directory.CreateDirectory("Starwars");

            var d = new DirectoryInfo("Starwars");

            //d.CreateSubdirectory("Galaxy");
            //d.Attributes
           

            Assert.True(true);
        }
        [Fact]
        public void DirectorioEliminar()
        {
            var d = new DirectoryInfo("Starwars");

            d.Delete();

            Assert.True(true);
        }
    }
}