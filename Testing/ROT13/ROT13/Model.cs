using System.Collections.Generic;

namespace ROT13
{
    public class Model
    {
        private Dictionary<char, char> schlüssel;

        public Model()
        {
            schlüssel = new Dictionary<char, char>();
            schlüssel.Add('A', 'N');
            schlüssel.Add('B', 'O');
            schlüssel.Add('C', 'P');
            schlüssel.Add('D', 'Q');
            schlüssel.Add('E', 'R');
            schlüssel.Add('F', 'S');
            schlüssel.Add('G', 'T');
            schlüssel.Add('H', 'U');
            schlüssel.Add('I', 'V');
            schlüssel.Add('J', 'W');
            schlüssel.Add('K', 'X');
            schlüssel.Add('L', 'Y');
            schlüssel.Add('M', 'Z');
            schlüssel.Add('N', 'A');
            schlüssel.Add('O', 'B');
            schlüssel.Add('P', 'C');
            schlüssel.Add('Q', 'D');
            schlüssel.Add('R', 'E');
            schlüssel.Add('S', 'F');
            schlüssel.Add('T', 'G');
            schlüssel.Add('U', 'H');
            schlüssel.Add('V', 'I');
            schlüssel.Add('W', 'J');
            schlüssel.Add('X', 'K');
            schlüssel.Add('Y', 'L');
            schlüssel.Add('Z', 'M');
        }

        public string Verarbeitung(string pfad)
        {
            string ausgabe = "";

            foreach (char item in new View().DateiEinlesen(pfad))
            {
                if (schlüssel.ContainsKey(item))
                    ausgabe += schlüssel[item];
                else ausgabe += item;
            }

            return ausgabe;
        }
    }
}
