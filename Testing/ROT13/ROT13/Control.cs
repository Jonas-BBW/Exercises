namespace ROT13
{
    class Control
    {
        static void Main(string[] args)
        {
            View v = new View();
            Model m = new Model();
            string text = "";

            string pfad = View.HolePfad();

            if (!v.DateiExistent(pfad))
            {
                text = View.HoleText();
            }
            else
            {
                text = m.Verarbeitung(pfad);
            }

            v.Speichern(pfad, text);
        }
    }
}
