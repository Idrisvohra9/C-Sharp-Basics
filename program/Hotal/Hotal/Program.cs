using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, i, r, u, qty, ch, total = 0;
            //do
            //{
                Console.WriteLine("---Menu---");
                Console.WriteLine("1.south Indian");
                Console.WriteLine("2.Panjabi");
                Console.WriteLine("3.Kathiyavadi");
                Console.WriteLine("4.EXIT");
                Console.WriteLine("Enter choice");
                n1 = Convert.ToInt16(Console.ReadLine());
                while (n1 != 4)
                {
                    switch (n1)
                    {
                        case 1:
                            {
                                i = 120; r = 160; u = 140; total = 0; qty = 0;
                                do{
                                Console.WriteLine("--- Sub Menu---");
                                Console.WriteLine("1.Idli sambhad     120 RS");
                                Console.WriteLine("2.Rava Masala Dosa 160 RS");
                                Console.WriteLine("3.Uttapam    140 RS");
                                Console.WriteLine("4.EXIT");
                                Console.WriteLine("Enter Your Choice");
                                ch = Convert.ToInt16(Console.ReadLine());
                                
                                    switch (ch)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter Your Quntity");
                                                qty = Convert.ToInt16(Console.ReadLine());
                                                total = qty * i;
                                                Console.WriteLine("ORDER BILL=" + total);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Enter Your Quntity");
                                                qty = Convert.ToInt16(Console.ReadLine());
                                                total = qty * r;
                                                Console.WriteLine("ORDER BILL=" + total);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Enter Your Quntity");
                                                qty = Convert.ToInt16(Console.ReadLine());
                                                total = qty * u;
                                                Console.WriteLine("ORDER BILL=" + total);
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Plz Enter Right Choice");
                                                break;
                                            }
                                    }
                                }while(ch!=4);
                                break;
                            }
                    }
                            case 2:
                            {
                                i = 160; r = 60; qty = 0; total = 0;
                                Console.WriteLine("--- Sub Menu---");
                                Console.WriteLine("1.pneer Tika Masala    160 RS");
                                Console.WriteLine("2.Butter Roti 60 RS");

                                Console.WriteLine("Enter Your Choice");
                                ch = Convert.ToInt16(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter Your Quntity");
                                            qty = Convert.ToInt16(Console.ReadLine());
                                            total = qty * i;
                                            Console.WriteLine("ORDER BILL=" + total);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Enter Your Quntity");
                                            qty = Convert.ToInt16(Console.ReadLine());
                                            total = qty * r;
                                            Console.WriteLine("ORDER BILL=" + total);
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Plz Enter Right Choice");
                                            break;
                                        }
                                }
                                break;
                            }
                        case 3:
                            i = 100; r = 90; qty = 0; total = 0;
                            Console.WriteLine("--- Sub Menu---");
                            Console.WriteLine("1.Dal Bati     100 RS");
                            Console.WriteLine("2.Churmo 90 RS");

                            Console.WriteLine("Enter Your Choice");
                            ch = Convert.ToInt16(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter Your Quntity");
                                        qty = Convert.ToInt16(Console.ReadLine());
                                        total = qty * i;
                                        Console.WriteLine("ORDER BILL=" + total);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter Your Quntity");
                                        qty = Convert.ToInt16(Console.ReadLine());
                                        total = qty * r;
                                        Console.WriteLine("ORDER BILL=" + total);
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("Plz Enter Right Choice");
                                        break;
                                    }

                            }

                            break;
                        default:
                            Console.WriteLine("Plz Enter Right Choice");
                            break;


                    }
                }
               // } while (n1 != 4||n1!=null);
            Console.ReadLine();

        }
    

