namespace Where
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    
        public override string ToString()
        {
            return $"{ Nome } ({ Categoria }): { Preco }";
        }
    }
}