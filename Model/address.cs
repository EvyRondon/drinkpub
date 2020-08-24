namespace drink.Model
{
    public class address
    {
        //const kind = ["cobrança, "comercial", "correspondência", "entrega", "residencial"];

        public string street { get; set; }
        public string number { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string complement { get; set; }

        public int kind { get; set; }
    }
}
