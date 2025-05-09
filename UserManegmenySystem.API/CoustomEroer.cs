namespace UserManegmenySystem.API
{ 

    public class CoustomEroer<T>
    {
        public string? Code { get; set; }

        public string Message { get; set; }

        public T? Result { get; set; }
    }
}
