namespace Practica5.Models
{
    public class Profesor
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI {  get; set; }
        public string Ciclo {  get; set; }
        public string Email {  get; set; }
        public byte[] Contraseña {  get; set; }
        public string Salt {  get; set; }
     }
}
