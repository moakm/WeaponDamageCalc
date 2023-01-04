using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WeaponDamageCalc
{
    internal class Program
    {
        static Random random = new();
        static void Main(string[] args)
        {

            SwordDamage sword = new(RollDice(3));
            ArrowDamage arrow = new(RollDice(1));
            bool main_menu = true;
            while (main_menu)
            {
                Console.Clear();
                Console.WriteLine("0 no flaming/magic,\n" +
                    "1 for magic,\n" +
                    "2 for flaming,\n" +
                    "3 for bothn\n" +
                    "anything else to quit.");
                char key = Console.ReadKey(true).KeyChar;
                if (key != '1' && key!= '2' && key != '3' && key != '0') return;
                Console.WriteLine("Choose weapon to caltulate damage: S - sword, A - arrow.");
                char u_input = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (u_input)
                {
                    case 'S':
                        sword.Roll = RollDice(3);
                        sword.Magic = (key == '1' || key == '3');
                        sword.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"rolled {sword.Roll} for {sword.Damage}HP");
                        Console.ReadLine();
                        break;
                        //bool magic_flag = false;
                        //bool flaming_flag = false;
                        //while (true)
                        //{
                        //    sword.Roll = RollDice(3);
                        //    Console.Clear();
                        //    Console.WriteLine("Calculating sword damage.");
                        //    Console.WriteLine($"1. Is Flaming ? -> {flaming_flag}\n" +
                        //        $"2. Is Magic ? -> {magic_flag}\n" +
                        //        $"3. Calculate damage.\n" +
                        //        $"4. Quit.");
                        //    char u = Console.ReadKey(true).KeyChar;
                        //    switch (u)
                        //    {
                        //        case '1':
                        //            if (flaming_flag) flaming_flag = false;
                        //            else flaming_flag = true;
                        //            break;
                        //        case '2':
                        //            if (magic_flag) magic_flag = false;
                        //            else magic_flag = true;
                        //            break;
                        //        case '3':
                        //            sword.Flaming = flaming_flag;
                        //            sword.Magic = magic_flag;
                        //            Console.WriteLine($"rolled {sword.Roll} for {sword.Damage}HP");
                        //            Console.WriteLine("Press anything to continue...");
                        //            Console.ReadKey();
                        //            break;
                        //        case '4':
                        //            return;
                        //        default:
                        //            continue;
                        //    }
                        //}
                    case 'A':
                        arrow.Roll = RollDice(3);
                        arrow.Magic = (key == '1' || key == '3');
                        arrow.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"rolled {arrow.Roll} for {arrow.Damage}HP");
                        Console.ReadLine();
                        break;
                        //while (true)
                        //{
                        //    Console.Clear();
                        //    Console.WriteLine("Calculating sword damage.");
                        //    Console.WriteLine($"1. Is Flaming ? -> {arrow.Flaming}\n" +
                        //        $"2. Is Magic ? -> {arrow.Magic}\n" +
                        //        $"3. Calculate damage.\n" +
                        //        $"4. Quit.");
                        //    char u1 = Console.ReadKey(true).KeyChar;
                        //    switch (u1)
                        //    {
                        //        case '1':
                        //            if (arrow.Flaming) arrow.Flaming = false;
                        //            else arrow.Flaming = true;
                        //            break;
                        //        case '2':
                        //            if (arrow.Magic) arrow.Magic = false;
                        //            else arrow.Magic = true;
                        //            break;
                        //        case '3':
                        //            arrow.Roll = RollDice(3);
                        //            Console.WriteLine($"rolled {arrow.Roll} for {arrow.Damage}HP");
                        //            Console.WriteLine("Press anything to continue...");
                        //            Console.ReadKey();
                        //            break;
                        //        case '4':
                        //            return;
                        //        default:
                        //            continue;
                        //    }
                        //}
                            
                            
                }
            }
        }
                
        public static int RollDice(int value)
        {
            int sum = 0;
            for (int i = 0; i < value; i++) sum += random.Next(1, 7);
            return sum;
        }

        public static void DisplaySwordDamage(SwordDamage weapon)
        {
            Console.WriteLine($"rolled {weapon.Roll} for {weapon.Damage}HP");
        }
        public static void DisplayArrowDamage(ArrowDamage weapon)
        {
            Console.WriteLine($"rolled {weapon.Roll} for {weapon.Damage}HP");
        }
    }
}