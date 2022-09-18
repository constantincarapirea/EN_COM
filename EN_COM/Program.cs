using System;

namespace EN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intoduceti Limba dorita");
            Console.WriteLine("1-EN");
            Console.WriteLine("2=RO");
            Random RNO = new Random();
            int ln = int.Parse(Console.ReadLine());
            int ran;
            switch (ln)
            {


                case 1:

                    break;

                case 2:
                    {
                        bool exit = true;

                        do
                        {
                            Console.WriteLine("=======Meniu========");
                            Console.WriteLine("1-->Culori");
                            Console.WriteLine("2-->Zile");
                            Console.WriteLine("3-->Materi");
                            Console.WriteLine("4-->Adjective");
                            Console.WriteLine("5-->Opinion adjectiv");
                            Console.WriteLine("6-->good");
                            Console.WriteLine("7-->bad");
                            Console.WriteLine("8-->Business cards & contact details");
                            Console.WriteLine("9-->Forms of communication");
                            Console.WriteLine("10-->Sending emails");
                            Console.WriteLine("11-->Homes,rooms and furniture");
                            Console.WriteLine("12-->Kitchen implements");
                            Console.WriteLine("13--Intrebari");
                            Console.WriteLine("14--Toileties and bathroom equipment");
                            Console.WriteLine("15--Household chores");
                            Console.WriteLine("0--Iesire");

                            int ro = int.Parse(Console.ReadLine());



                            switch (ro)
                            {
                                case 1:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("red", "Rosu"); list.Add("");
                                            dict.Add("yellow", "Galben "); list.Add("");
                                            dict.Add("green", "Verde"); list.Add("");
                                            dict.Add("dark green", "Verde inchis"); list.Add("");
                                            dict.Add("pale green", "Verde deschis"); list.Add("");
                                            dict.Add("blue", "Albastru"); list.Add("");
                                            dict.Add("pink", "Roz"); list.Add("");
                                            dict.Add("pruple", "Violet"); list.Add("");
                                            dict.Add("white", "Alb"); list.Add("");
                                            dict.Add("gray", "Sur"); list.Add("");
                                            dict.Add("black", "Negru"); list.Add("");
                                            dict.Add("brown", "Cafeniu"); list.Add("");
                                            dict.Add("orage", "Oranj"); list.Add("");
                                            dict.Add("navy blue", "Albastru inchis"); list.Add("");
                                           

                                            for (int i = 0; i < dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("monday", "Luni"); list.Add("");
                                            dict.Add("tuesday", "Marti "); list.Add("");
                                            dict.Add("wednesday", "Mercuri"); list.Add("");
                                            dict.Add("thursday", "Joi"); list.Add("");
                                            dict.Add("friday", "Vineri"); list.Add("");
                                            dict.Add("saturday", "Sambata"); list.Add("");
                                            dict.Add("sunday", "Duminca"); list.Add("");
                                            dict.Add("day", "Zi"); list.Add("");
                                            dict.Add("months", "Luna"); list.Add("");
                                            dict.Add("week", "Saptamina"); list.Add("");
                                            dict.Add("years", "Ani"); list.Add("");
                                            for (int i = 0; i < dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;                                     
                                case 3:
                                    {
                                        for (int i = 0; i < 15; i++)
                                        {
                                            ran = RNO.Next(1, 15);

                                            switch (ran)
                                            {
                                                case 1:
                                                    {
                                                        string dic = "Plastic";
                                                        string dic1 = "plastic";
                                                        Console.Write("Materie de plastic--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        string dic = "Wood";
                                                        string dic1 = "wood";
                                                        Console.Write("Lenm--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        string dic = "Paper";
                                                        string dic1 = "paper";
                                                        Console.Write("Hirtie--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 4:
                                                    {
                                                        string dic = "Wool";
                                                        string dic1 = "wool";
                                                        Console.Write("Lina--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 5:
                                                    {
                                                        string dic = "Leather";
                                                        string dic1 = "leather";
                                                        Console.Write("Piele--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 6:
                                                    {
                                                        string dic = "Metal";
                                                        string dic1 = "metal";
                                                        Console.Write("Metal--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 7:
                                                    {
                                                        string dic = "Glass";
                                                        string dic1 = "glass";
                                                        Console.Write("Sticla--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 8:
                                                    {
                                                        string dic = "Fabric";
                                                        string dic1 = "fabric";
                                                        Console.Write("Tesatura--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 9:
                                                    {
                                                        string dic = "Denim";
                                                        string dic1 = "denim";
                                                        Console.Write("djinsi--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 10:
                                                    {
                                                        string dic = "Silk";
                                                        string dic1 = "silk";
                                                        Console.Write("Matase--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;


                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        for (int i = 0; i < 15; i++)
                                        {
                                            ran = RNO.Next(1, 15);

                                            switch (ran)
                                            {
                                                case 1:
                                                    {
                                                        string dic = "Big";
                                                        string dic1 = "big";
                                                        Console.Write("Mare--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        string dic = "small";
                                                        string dic1 = "little";
                                                        Console.Write("mic--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        string dic = "Wide";
                                                        string dic1 = "wide";
                                                        Console.Write("Larg--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 4:
                                                    {
                                                        string dic = "Narrow";
                                                        string dic1 = "narrow";
                                                        Console.Write("Ingust--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 5:
                                                    {
                                                        string dic = "Deep";
                                                        string dic1 = "deep";
                                                        Console.Write("Adinc--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 6:
                                                    {
                                                        string dic = "Shallow";
                                                        string dic1 = "shallow";
                                                        Console.Write("putin adinc--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 7:
                                                    {
                                                        string dic = "High";
                                                        string dic1 = "high";
                                                        Console.Write("inalt--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Hai");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 8:
                                                    {
                                                        string dic = "Low";
                                                        string dic1 = "low";
                                                        Console.Write("mic|scazult--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lou");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 9:
                                                    {
                                                        string dic = "Heavy";
                                                        string dic1 = "heavy";
                                                        Console.Write("greu--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>hevi");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 10:
                                                    {
                                                        string dic = "Light";
                                                        string dic1 = "light";
                                                        Console.Write("usor--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 11:
                                                    {
                                                        string dic = "Clean";
                                                        string dic1 = "clean";
                                                        Console.Write("curat--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 12:
                                                    {
                                                        string dic = "Dirty";
                                                        string dic1 = "dirty";
                                                        Console.Write("murdar--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }
                                                    }
                                                    break;

                                                case 13:
                                                    {
                                                        string dic = "Hot";
                                                        string dic1 = "hot";
                                                        Console.Write("Cald--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 14:
                                                    {
                                                        string dic = "Cold";
                                                        string dic1 = "cold";
                                                        Console.Write("Rece--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 15:
                                                    {
                                                        string dic = "Long";
                                                        string dic1 = "long";
                                                        Console.Write("lung--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 16:
                                                    {
                                                        string dic = "Short";
                                                        string dic1 = "short";
                                                        Console.Write("scurt--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;

                                                case 17:
                                                    {
                                                        string dic = "Thick";
                                                        string dic1 = "thick";
                                                        Console.Write("Gros--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 18:
                                                    {
                                                        string dic = "thim";
                                                        string dic1 = "thim";
                                                        Console.Write("subtire--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 19:
                                                    {
                                                        string dic = "Quiet";
                                                        string dic1 = "quiet";
                                                        Console.Write("liniste--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>cua-iet");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 20:
                                                    {
                                                        string dic = "Loud";
                                                        string dic1 = "loud";
                                                        Console.Write("tare| zgomotos--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>laud");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 21:
                                                    {
                                                        string dic = "Sharp";
                                                        string dic1 = "sharp";
                                                        Console.Write("Ascutit--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>Lait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 22:
                                                    {
                                                        string dic = "tight";
                                                        string dic1 = "tight";
                                                        Console.Write("strins--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>tait");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 23:
                                                    {
                                                        string dic = "Loose";
                                                        string dic1 = "loose";
                                                        Console.Write("leger| slab--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>luz");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 24:
                                                    {
                                                        string dic = "Near";
                                                        string dic1 = "near";
                                                        Console.Write("Aproape--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>nir");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 25:
                                                    {
                                                        string dic = "far";
                                                        string dic1 = "far";
                                                        Console.Write("departe--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!>>far");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;

                                            }
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                                        for (int i = 0; i < 15; i++)
                                                        {
                                                            ran = RNO.Next(1, 15);

                                                            switch (ran)
                                                            {
                                                                case 1:
                                                                    {
                                                                        string dic = "Nice";
                                                                        string dic1 = "nice";
                                                                        Console.Write("Grozav--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 2:
                                                                    {
                                                                        string dic = "Fun";
                                                                        string dic1 = "fun";
                                                                        Console.Write("Distractie--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 3:
                                                                    {
                                                                        string dic = "Lovely";
                                                                        string dic1 = "lovely";
                                                                        Console.Write("Minunat--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 4:
                                                                    {
                                                                        string dic = "Delicious";
                                                                        string dic1 = "delicious";
                                                                        Console.Write("Delicios--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 5:
                                                                    {
                                                                        string dic = "Exciting";
                                                                        string dic1 = "exciting";
                                                                        Console.Write("Captivant--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 6:
                                                                    {
                                                                        string dic = "Thrilling";
                                                                        string dic1 = "thrilling";
                                                                        Console.Write("Infiorare--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        string dic = "Interesting";
                                                                        string dic1 = "interesting";
                                                                        Console.Write("Interesant--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        string dic = "Respectable";
                                                                        string dic1 = "respectable";
                                                                        Console.Write("Respectabl--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        string dic = "Special";
                                                                        string dic1 = "special";
                                                                        Console.Write("Special--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 10:
                                                                    {
                                                                        string dic = "Graveful";
                                                                        string dic1 = "graceful";
                                                                        Console.Write("Gratios--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 11:
                                                                    {
                                                                        string dic = "Pleasant";
                                                                        string dic1 = "pleasant";
                                                                        Console.Write("Placut--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 12:
                                                                    {
                                                                        string dic = "Useful";
                                                                        string dic1 = "useful";
                                                                        Console.Write("util--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;

                                                                case 13:
                                                                    {
                                                                        string dic = "Important";
                                                                        string dic1 = "important";
                                                                        Console.Write("Important--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 14:
                                                                    {
                                                                        string dic = "Relaxing";
                                                                        string dic1 = "relaxging";
                                                                        Console.Write("Relaxant--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 15:
                                                                    {
                                                                        string dic = "Harmless";
                                                                        string dic1 = "harmless";
                                                                        Console.Write("Inofensiv--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 16:
                                                                    {
                                                                        string dic = "Frightening";
                                                                        string dic1 = "frightening";
                                                                        Console.Write("Infricosator--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 17:
                                                                    {
                                                                        string dic = "Shocking";
                                                                        string dic1 = "shocking";
                                                                        Console.Write("Socant--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 18:
                                                                    {
                                                                        string dic = "Irritating";
                                                                        string dic1 = "irritating";
                                                                        Console.Write("eneravan,iritant--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 19:
                                                                    {
                                                                        string dic = "Annoying";
                                                                        string dic1 = "Annoying";
                                                                        Console.Write("eneravan,suparator--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 20:
                                                                    {
                                                                        string dic = "Horrible";
                                                                        string dic1 = "horrible";
                                                                        Console.Write("oribil--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 21:
                                                                    {
                                                                        string dic = "Nasty";
                                                                        string dic1 = "nasty";
                                                                        Console.Write("Neplacut--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 22:
                                                                    {
                                                                        string dic = "Old-fashioned";
                                                                        string dic1 = "old-fashioned";
                                                                        Console.Write("de moda veche--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 23:
                                                                    {
                                                                        string dic = "Unpleasant";
                                                                        string dic1 = "Unpleasant";
                                                                        Console.Write("neplacut--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 24:
                                                                    {
                                                                        string dic = "Disastrous";
                                                                        string dic1 = "disastrous";
                                                                        Console.Write("Dezastruos--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 25:
                                                                    {
                                                                        string dic = "Useless";
                                                                        string dic1 = "useless";
                                                                        Console.Write("Inutil--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 26:
                                                                    {
                                                                        string dic = "Stunning";
                                                                        string dic1 = "stunning";
                                                                        Console.Write("uluitor,uimitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 27:
                                                                    {
                                                                        string dic = "Magnificent";
                                                                        string dic1 = "magnificent";
                                                                        Console.Write("magnific--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 28:
                                                                    {
                                                                        string dic = "Pretty";
                                                                        string dic1 = "pretty";
                                                                        Console.Write("Frumos--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 29:
                                                                    {
                                                                        string dic = "Beautiful";
                                                                        string dic1 = "beautiful";
                                                                        Console.Write("Frumosa--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;


                                                                case 30:
                                                                    {
                                                                        string dic = "Disgusting";
                                                                        string dic1 = "disgusting";
                                                                        Console.Write("Dezgustător--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;



                                                                case 31:
                                                                    {
                                                                        string dic = "Boring";
                                                                        string dic1 = "boring";
                                                                        Console.Write("Plictisitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;


                                                                case 32:
                                                                    {
                                                                        string dic = "Ugly";
                                                                        string dic1 = "ugly";
                                                                        Console.Write("Urit--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;


                                                                case 33:
                                                                    {
                                                                        string dic = "strange";
                                                                        string dic1 = "odd";
                                                                        Console.Write("Ciudat--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 34:
                                                                    {
                                                                        string dic = "Confusing";
                                                                        string dic1 = "confusing";
                                                                        Console.Write("Confuz--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 35:
                                                                    {
                                                                        string dic = "Tiring";
                                                                        string dic1 = "Tiring";
                                                                        Console.Write("Obositor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;

                                                            }
                                                        }
                                                    }
                                    break;
                                case 6:
                                    {
                                                        for (int i = 0; i < 15; i++)
                                                        {
                                                            ran = RNO.Next(1, 15);

                                                            switch (ran)
                                                            {
                                                                case 1:
                                                                    {
                                                                        string dic = "Great";
                                                                        string dic1 = "great";
                                                                        Console.Write("Grozav--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 2:
                                                                    {
                                                                        string dic = "Amazing";
                                                                        string dic1 = "amazing";
                                                                        Console.Write("uimitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 3:
                                                                    {
                                                                        string dic = "Extraordinary";
                                                                        string dic1 = "extraordinary";
                                                                        Console.Write("Extraordinar--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 4:
                                                                    {
                                                                        string dic = "outstanding";
                                                                        string dic1 = "remarkable";
                                                                        Console.Write("Remarcabil--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 5:
                                                                    {
                                                                        string dic = "Breathtaking";
                                                                        string dic1 = "breathtaking";
                                                                        Console.Write("uluitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 6:
                                                                    {
                                                                        string dic = "Wondeful";
                                                                        string dic1 = "wondeful";
                                                                        Console.Write("Minunat--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        string dic = "Fantastic";
                                                                        string dic1 = "fantastic";
                                                                        Console.Write("Fantastic--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!>>Hai");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        string dic = "Incredible";
                                                                        string dic1 = "incredible";
                                                                        Console.Write("Incredibil--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!>>Lou");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        string dic = "Brilliant";
                                                                        string dic1 = "brilliant";
                                                                        Console.Write("Sclipitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!>>hevi");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 10:
                                                                    {
                                                                        string dic = "Superb";
                                                                        string dic1 = "superb";
                                                                        Console.Write("super--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!>>Lait");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;


                                                            }
                                                        }
                                                    }
                                    break;
                                case 7:
                                    {
                                                        for (int i = 0; i < 15; i++)
                                                        {
                                                            ran = RNO.Next(1, 15);

                                                            switch (ran)
                                                            {
                                                                case 1:
                                                                    {
                                                                        string dic = "Awful";
                                                                        string dic1 = "awful";
                                                                        Console.Write("Ingrozitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 2:
                                                                    {
                                                                        string dic = "Terrible";
                                                                        string dic1 = "terrible";
                                                                        Console.Write("Teribil--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 3:
                                                                    {
                                                                        string dic = "Disappointing";
                                                                        string dic1 = "disappointing";
                                                                        Console.Write("Dezamagitor--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 4:
                                                                    {
                                                                        string dic = "Mediocre";
                                                                        string dic1 = "mediocre";
                                                                        Console.Write("Mediocru--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;


                                                            }
                                                        }
                                                    }
                                    break;
                                case 8:
                                    {
                                                        for (int i = 0; i < 15; i++)
                                                        {
                                                            ran = RNO.Next(1, 15);

                                                            switch (ran)
                                                            {
                                                                case 1:
                                                                    {
                                                                        string dic = "Title";
                                                                        string dic1 = "title";
                                                                        Console.Write("Titlu--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 2:
                                                                    {
                                                                        string dic = "First name";
                                                                        string dic1 = "first name";
                                                                        Console.Write("Nume--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 3:
                                                                    {
                                                                        string dic = "Last name";
                                                                        string dic1 = "last name";
                                                                        Console.Write("Familia--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 4:
                                                                    {
                                                                        string dic = "House number";
                                                                        string dic1 = "house number";
                                                                        Console.Write("Numarul de casa--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 5:
                                                                    {
                                                                        string dic = "Street address";
                                                                        string dic1 = "street address";
                                                                        Console.Write("Adresa strazii--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 6:
                                                                    {
                                                                        string dic = "State";
                                                                        string dic1 = "state";
                                                                        Console.Write("Tara--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        string dic = "zip code";
                                                                        string dic1 = "postcode";
                                                                        Console.Write("Codul postal--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        string dic = "City";
                                                                        string dic1 = "city";
                                                                        Console.Write("Orasul--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        string dic = "Email address";
                                                                        string dic1 = "Email address";
                                                                        Console.Write("Adresa de email--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 10:
                                                                    {
                                                                        string dic = "cell phone number";
                                                                        string dic1 = "mobile number";
                                                                        Console.Write("Numarul de telefon--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 11:
                                                                    {
                                                                        string dic = "Name";
                                                                        string dic1 = "name";
                                                                        Console.Write("Nume--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 12:
                                                                    {
                                                                        string dic = "Website";
                                                                        string dic1 = "website";
                                                                        Console.Write("Sait-ul web--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 13:
                                                                    {
                                                                        string dic = "Business card";
                                                                        string dic1 = "business card";
                                                                        Console.Write("Carte de vizita--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 14:
                                                                    {
                                                                        string dic = "Job title ";
                                                                        string dic1 = "job title";
                                                                        Console.Write("Denumirea functiei--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 15:
                                                                    {
                                                                        string dic = "Company name";
                                                                        string dic1 = "company name";
                                                                        Console.Write("Denumirea companiei--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic || cuv == dic1)
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 17:
                                                                    {
                                                                        string dic = "to introduce yourself";
                                                                        Console.Write("sa te prezinti--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic )
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;
                                                                case 18:
                                                                    {
                                                                        string dic = "to exchange business card";
                                                                        Console.Write("a schimba carte de vizita--> ");
                                                                        string cuv = Console.ReadLine();
                                                                        if (cuv == dic )
                                                                        {
                                                                            Console.WriteLine("Corect!!");
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine($"Incorect>> {dic}");
                                                                        }

                                                                    }
                                                                    break;



                                                            }
                                                        }
                                                    }
                                    break;
                                case 9:
                                    {
                                        for (int i = 0; i < 15; i++)
                                        {
                                            ran = RNO.Next(1, 15);

                                            switch (ran)
                                            {
                                                case 1:
                                                    {
                                                        string dic = "Letter";
                                                        string dic1 = "letter";
                                                        Console.Write("Scrisoare--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        string dic = "Phone call";
                                                        string dic1 = "phone call ";
                                                        Console.Write("Apel telefonuc--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        string dic = "Voicemail";
                                                        string dic1 = "voicemail";
                                                        Console.Write("Mesagerie vocala--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 4:
                                                    {
                                                        string dic = "Text message";
                                                        string dic1 = "text message";
                                                        Console.Write("Mesaj text--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;

                                                case 5:
                                                    {
                                                        string dic = "social networking";
                                                        Console.Write("Retea sociala--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 6:
                                                    {
                                                        string dic = "Memo";
                                                        string dic1 = "memo";
                                                        Console.Write("Notificare--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 7:
                                                    {
                                                        string dic = "online chat";
                                                        Console.Write("Convertatie online--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 8:
                                                    {
                                                        string dic = "post";
                                                        string dic1 = "email";
                                                        Console.Write("Posta--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                                case 9:
                                                    {
                                                        string dic = "Note";
                                                        string dic1 = "Note";
                                                        Console.Write("Nota--> ");
                                                        string cuv = Console.ReadLine();
                                                        if (cuv == dic || cuv == dic1)
                                                        {
                                                            Console.WriteLine("Corect!!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {dic}");
                                                        }

                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                                case 10:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("inbox", "A primi mesaj"); list.Add("");
                                            dict.Add("outbox", "A timite mesajul"); list.Add("");
                                            dict.Add("draft", "Schita,plan"); list.Add("");
                                            dict.Add("junk mail", "lisat neagra"); list.Add("jonk mel");
                                            dict.Add("spam", "lisat neagra"); list.Add("spem");
                                            dict.Add("trash", "Gunoi"); list.Add("");
                                            dict.Add("attachment", "Atasament,fixare"); list.Add("");
                                            dict.Add("subject", "Subiect"); list.Add("sab-djct");
                                            dict.Add("signature", "Semnatura"); list.Add("signaciar");
                                            dict.Add("to print", "la imprimanta"); list.Add("");
                                            dict.Add("to reply", "a raspunde"); list.Add("");
                                            dict.Add("to rely all", "a raspunde tuturor"); list.Add("");
                                            dict.Add("to forward", "a  transmite"); list.Add("fo-uad");
                                            dict.Add("to send", "a trimite"); list.Add("");
                                            dict.Add("to delete", "a sterge"); list.Add("");


                                            for (int i = 0; i <= dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;      
                                case 11:
                                    {
                                        Dictionary<string, string> dict = new Dictionary<string, string>();
                                        List<string> list = new List<string>();
                                        dict.Add("balcony", "Balcon"); list.Add("");
                                        dict.Add("block of flats", "Bloc de apartament "); list.Add("");
                                        dict.Add("door", "Usa"); list.Add("");
                                        dict.Add("roof", "Acoperis"); list.Add("");
                                        dict.Add("house", "Casa"); list.Add("");
                                        dict.Add("lawn", "gazon"); list.Add("");
                                        dict.Add("attic", "pod,masarda"); list.Add("atik");
                                        dict.Add("upstairs", "etaj de sus"); list.Add("ap-sterz");
                                        dict.Add("stairs", "scari"); list.Add("");
                                        dict.Add("basement", "subsol"); list.Add("besement");
                                        dict.Add("yard", "Curte"); list.Add("");
                                        dict.Add("garden", "Curte"); list.Add("");
                                        dict.Add("downstairs", "etajul de jos"); list.Add("");
                                        dict.Add("window", "trei zile in urma"); list.Add("");
                                        dict.Add("living room", "saptamina trecuta"); list.Add("");
                                        dict.Add("armchair", "fotoliu"); list.Add("");
                                        dict.Add("couch", "canapea"); list.Add("cauci");
                                        dict.Add("sofa", "canapea"); list.Add("");
                                        dict.Add("bedroom", "dulap pentru haine"); list.Add("");
                                        dict.Add("wardrobe", "tirziu"); list.Add("");
                                        dict.Add("lamp", "lampa"); list.Add("");
                                        dict.Add("bed", "pat"); list.Add("");
                                        dict.Add("dresser", "dulap cu setare"); list.Add("");
                                        dict.Add("chest of drawers", "dulap cu setare"); list.Add("");
                                        dict.Add("bedside table", "noptiera"); list.Add("");
                                        dict.Add("cushion", "pierna"); list.Add("");
                                        dict.Add("rug", "covor"); list.Add("");
                                        dict.Add("light", "plafon"); list.Add("");
                                        dict.Add("dining room", "sala de masa"); list.Add("");
                                        dict.Add("table", "Masa"); list.Add("");
                                        dict.Add("chair", "scaun"); list.Add("");
                                        dict.Add("study", "studiu"); list.Add("");
                                        dict.Add("desk", "birou"); list.Add("");
                                        dict.Add("bookcase", "dulap pentru carti"); list.Add("");
                                        dict.Add("bathroom", "baie"); list.Add("");
                                        dict.Add("shower", "cabina de dus"); list.Add("");
                                        dict.Add("towel", "prosop"); list.Add("taual");
                                        dict.Add("bathtub", "cada"); list.Add("baf-tab");
                                        dict.Add("freezer", "morozilnic"); list.Add("frizar");
                                        dict.Add("fridge", "fregider"); list.Add("fredji");
                                        dict.Add("refrigerator", "fregider"); list.Add("");
                                        dict.Add("stove", "aragaz"); list.Add("");
                                        dict.Add("cooker", "aragaz"); list.Add("");
                                        dict.Add("sink", "lavoar"); list.Add("");
                                        dict.Add("dishwasher", "masina de spalat vesela"); list.Add("");
                                        dict.Add("trash can", "cos de gunoi"); list.Add("");
                                        dict.Add("bin", "cos de gunoi"); list.Add("");
                                        dict.Add("cupboard", "dulap de bucatarie"); list.Add("");
                                        dict.Add("cabinet", "dulap de bucatarie"); list.Add("");

                                        for (int i = 0; i <=dict.Count - 1; i++)
                                        {
                                            {
                                                var item = dict.ElementAt(i);
                                                Console.Write($"{item.Value}--->");
                                                string dic = Console.ReadLine();
                                                {
                                                    if (true == dict.ContainsKey(dic))
                                                    {
                                                        Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                    }


                                                }

                                            }
                                        }
                                    }
                                        break;
                                case 12:
                                    {
                                        Dictionary<string, string> dict = new Dictionary<string, string>();
                                        List<string> list = new List<string>();
                                        dict.Add("grater", "razatoare"); list.Add("greitar");
                                        dict.Add("peeler", "Razatoare pentru caroafe"); list.Add("pilar");
                                        dict.Add("whisk", "batator(de oua)"); list.Add("uisk");
                                        dict.Add("cutting board", "Fund"); list.Add("catin bo:rd");
                                        dict.Add("chopping board", "Fund"); list.Add("ciopin bo:rd");
                                        dict.Add("kitchen knife", "cutit de bucatarie"); list.Add("");
                                        dict.Add("scissors", "farfice"); list.Add("sizaz");
                                        dict.Add("can opener", "deschizator de conserve"); list.Add("");
                                        dict.Add("tin opener", "deschizator de conserve"); list.Add("");
                                        dict.Add("bottle opener", "deschizator de sticle"); list.Add("batl opener");
                                        dict.Add("corkscrew", "tirbuson(deschizator de vin)"); list.Add("kork-skru:");
                                        dict.Add("wooden spoon", "lingura de lemn"); list.Add("uden spu:n");
                                        dict.Add("spatula", "perie de plastic(pentru a intinde ulei)"); list.Add("spashala");
                                        dict.Add("ladle", "polonic"); list.Add("leidl");
                                        dict.Add("toaster", "prajitor de paine"); list.Add("touster");
                                        dict.Add("microwave", "microunda"); list.Add("maicro-uei");
                                        dict.Add("kettle", "ceainic"); list.Add("kedl");
                                        dict.Add("dinnerwave", "vesela"); list.Add("dinnar-ueiv");
                                        dict.Add("crockery", "vesela"); list.Add("crakari");
                                        dict.Add("plate", "farfurie"); list.Add("pleit");
                                        dict.Add("bowl", "castron"); list.Add("boul");
                                        dict.Add("cup", "ceasca"); list.Add("cap");
                                        dict.Add("mug", "cana"); list.Add("mag");
                                        dict.Add("silverwave", "tacimuri"); list.Add("silvar-ueiv");
                                        dict.Add("cutlery", "tacimuri"); list.Add("catlari");
                                        dict.Add("knife", "cutit"); list.Add("");
                                        dict.Add("fork", "furculita"); list.Add("");
                                        dict.Add("spoon", "lingura"); list.Add("spun");
                                        dict.Add("chopsticks", "betisoare de mancat(japonez)"); list.Add("ciopstiks");
                                        dict.Add("saucepan", "cratita"); list.Add("sos-pan");
                                        dict.Add("frying pan", "tigaie"); list.Add("fraiin-pan");
                                        dict.Add("wok", "wok(tigaie mare de fonta)"); list.Add("uak");
                                        dict.Add("colander", "strecatoare"); list.Add("calandar");
                                        dict.Add("blender", "blender"); list.Add("");
                                        dict.Add("rolling pin", "citor"); list.Add("rolin pin");
                                        dict.Add("mortar", "tencui,mojar"); list.Add("mordar");
                                        dict.Add("pestle", "(mojar) framinta"); list.Add("pesl");
                                        dict.Add("pestle and mortar", "vas de a farminta"); list.Add("");
                                        dict.Add("sieve", "sita pentru macaroane"); list.Add("siv");
                                        dict.Add("fish slice","sitor"); list.Add("fish slais");
                                       
                                        for (int i = 0; i < dict.Count - 1; i++)
                                        {
                                            {
                                                var item = dict.ElementAt(i);
                                                Console.Write($"{item.Value}--->");
                                                string dic = Console.ReadLine();
                                                {
                                                    if (true == dict.ContainsKey(dic))
                                                    {
                                                        Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                    }


                                                }

                                            }
                                        }
                                    }
                                    break;
                                case 13:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("what", "Ce"); list.Add("");
                                            dict.Add("where", "unde "); list.Add("");
                                            dict.Add("when", "cind"); list.Add("");
                                            dict.Add("who", "cine"); list.Add("");
                                            dict.Add("why", "de ce"); list.Add("");
                                           
                                            for (int i = 0; i < dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;
                                case 14:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("shampoo", "sampon"); list.Add("shapu:");
                                            dict.Add("conditioner", "balzam"); list.Add("con-dishanar");
                                            dict.Add("moisturizer", "crema hidratanta pentru fata"); list.Add("moisci-raizar");
                                            dict.Add("razor", "brici"); list.Add("reizor");
                                            dict.Add("shaving foam", "Vineri"); list.Add("seivin fum");
                                            dict.Add("shower gel", "gel de dus"); list.Add("sauar gel");
                                            dict.Add("deodorant", "deodorant"); list.Add("di'odarant");
                                            dict.Add("soap", "sapun"); list.Add("sup");
                                            dict.Add("toothbrush", "periuta da dinti"); list.Add("tud-bras");
                                            dict.Add("toothpaste", "pasta de dinti"); list.Add("tud-peist");
                                            dict.Add("mouthwash", "apa de gura(miros)"); list.Add("mauf-uas");
                                            dict.Add("dental floss", "ata dentara"); list.Add("dento flas");
                                            dict.Add("sponge", "burete de baie"); list.Add("spandj");
                                            dict.Add("face wash", "spala fata"); list.Add("feis uas");
                                            dict.Add("toilet paper", "hirtie igienica"); list.Add("toilit peipar");


                                            for (int i = 0; i <=dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;
                                case 15:
                                    {
                                        {
                                            Dictionary<string, string> dict = new Dictionary<string, string>();
                                            List<string> list = new List<string>();
                                            dict.Add("to clean the windows", "a spala gemul"); list.Add("");
                                            dict.Add("to sweep the floor", "a matura pe jos"); list.Add("tu sui:p de flu:r");
                                            dict.Add("to scrub the floor", "a freca /spala podeaua "); list.Add("tu skrab de flu:r");
                                            dict.Add("to mop the floor", "a strege podeaua"); list.Add("tu map de flu:r");
                                            dict.Add("to vacuum the carpet", "a aspira covorul"); list.Add("tu vachium de carpet");
                                            dict.Add("to dust", "scutura de praf"); list.Add("tu dast");
                                            dict.Add("to take out the trash", "a duce gunoiul"); list.Add("tu teik aut de tra");
                                            dict.Add("to take out the rubbish", "a  duce gunoiul "); list.Add("tu teik aut rabish ");
                                            dict.Add("to clean up", "a face ordine"); list.Add("tud-bras");
                                            dict.Add("to tidy", "a face ordine"); list.Add("tu taidi");
                                            dict.Add("to go  to the store", "a merge la magazin"); list.Add("tu go tu de sto:r");
                                            dict.Add("to go to the shops", "a merge la magazin"); list.Add("tu go tu de shops");
                                            dict.Add("to clean the bathroom", "a curati baia"); list.Add("");
                                            dict.Add("to set the table", "a pune masa"); list.Add("tu set de teibl");
                                            dict.Add("to clear the table", "a curati masa"); list.Add("");
                                            dict.Add("to do the dishes", "a spala vesela"); list.Add("tu du de disis");
                                            dict.Add("to dry the dishes", "a usca vesela"); list.Add("tu drai de disis");
                                            dict.Add("to load the dishwasher", "a incarca masina de spalat vesela"); list.Add("tu lod de dis-uasar");
                                            dict.Add("to unload the dishwasher", "a descarca masina de spalat vesela"); list.Add("tu an-lod de dis-uasar");
                                            dict.Add("to do the laundry", "a spala rufele"); list.Add("tu du de lo:ndri");
                                            dict.Add("to hang clothes", "a atirna hanile "); list.Add("tu han clauvz");
                                            dict.Add("to do the ironing", "a calca rufele"); list.Add("tu du de arianin");
                                            dict.Add("to fold clothes", "a impaturi hainele"); list.Add("tu fold clovs");
                                            dict.Add("to make the bed", "a face patul "); list.Add("tu meik de bad");
                                            dict.Add("to change the sheets", "a schimba cersafulrile"); list.Add("tu cenji de si:ts");
                                            dict.Add("to water the plants", "a uda plantele"); list.Add("tu uatar de pla:nts");
                                            dict.Add("to wash the car", "a spala masina"); list.Add("tu uas de car");
                                            dict.Add("to feed the pets", "a hrani animalele de casa "); list.Add("tu fi:d de pets");
                                            for (int i = 0; i <= dict.Count - 1; i++)
                                            {
                                                {
                                                    var item = dict.ElementAt(i);
                                                    Console.Write($"{item.Value}--->");
                                                    string dic = Console.ReadLine();
                                                    {
                                                        if (true == dict.ContainsKey(dic))
                                                        {
                                                            Console.WriteLine($"Corect>>{item.Key}[{list[i]}]");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"Incorect>> {item.Key}[{list[i]}]");
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }
                                    break;
                                case 0:
                                    exit = false;
                                    break;
                            }
                        } while (exit);

                    }

                    break;
                  
            }
        }
    }
}
