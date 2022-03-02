namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia() // Protected quem herdar dessa classe tera acesso.
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2() // Private so pode ser utilizado dentro dessa classe.
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3() // Public pode ser utilizado em qualquer classe
                                                // e o virtual permite que uma classe filha sobrescreva esse metodo
        {
            //Faz alguma coisa...
        }
    }
}