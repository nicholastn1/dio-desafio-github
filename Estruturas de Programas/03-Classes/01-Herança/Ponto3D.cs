namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular() // Para ser acessado de fora tem que chamar a partir da classe Ponto3D....
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3() // Sobrescreve o metodo se possuir o "virtual".
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}