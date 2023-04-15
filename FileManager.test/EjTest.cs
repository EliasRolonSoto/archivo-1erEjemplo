namespace FileManager.test
{
   public class EjTest
    {
        [Fact]
        public void CarpetaAPartirDeFecha() 
        {
            //1)Fecha
            //2)Crear directorios para cada parte
            //Ejemplo: Carpeta 2023/04/11

            //3)Escribir un archivo con nombre de la fecha 2023/04/11/2023-04-11.txt

            //4)Bonus track: Serializar un objeto y escribirlo dentro del archivo


            var fecha = DateTime.Now;

            var d = new DirectoryInfo("C:/Users/EliasRS/Desktop/Año2023");
            

            Assert.True(true);


            


        }
    }
}