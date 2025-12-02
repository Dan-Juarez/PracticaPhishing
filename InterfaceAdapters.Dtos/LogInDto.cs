namespace InterfaceAdapters.Dtos
{
    public class LogInRequestModel
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }

    public class LogInResponseModel
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
