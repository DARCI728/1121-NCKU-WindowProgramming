namespace ShoppingCartSystem {
    class Program {
        static void Main(string[] args) {
            int currency = 1, function, product, quantity, payment_method, sum;
            int[] shopping_cart = new int[3];
            bool end = false, inventory;
            String ans, discount_code;

            while (end == false) {
                Console.WriteLine("(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4)查看購物車 (5)結帳 (6)轉換幣值 (7)退出網站");
                Console.Write("請輸入數字選擇功能：");
                function = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (function) {
                    case 1:
                        if (currency == 1) {
                            Console.WriteLine("列表：");
                            Console.WriteLine("商品名稱\t\t商品單價");
                            Console.WriteLine("1.潛水相機防丟繩\t(TWD){0}", 199);
                            Console.WriteLine("2.潛水配重帶\t\t(TWD){0}", 460);
                            Console.WriteLine("3.潛水作業指北針\t(TWD){0}", 1100);
                        } else if (currency == 2) {
                            Console.WriteLine("列表：");
                            Console.WriteLine("商品名稱\t\t商品單價");
                            Console.WriteLine("1.潛水相機防丟繩\t(USD){0}", 199 * 0.031);
                            Console.WriteLine("2.潛水配重帶\t\t(USD){0}", 460 * 0.031);
                            Console.WriteLine("3.潛水作業指北針\t(USD){0}", 1100 * 0.031);
                        } else if (currency == 3) {
                            Console.WriteLine("列表：");
                            Console.WriteLine("商品名稱\t\t商品單價");
                            Console.WriteLine("1.潛水相機防丟繩\t(CNY){0}", 199 * 0.23);
                            Console.WriteLine("2.潛水配重帶\t\t(CNY){0}", 105.8);
                            Console.WriteLine("3.潛水作業指北針\t(CNY){0}", 1100 * 0.23);
                        } else if (currency == 4) {
                            Console.WriteLine("列表：");
                            Console.WriteLine("商品名稱\t\t商品單價");
                            Console.WriteLine("1.潛水相機防丟繩\t(JPY){0}", 199 * 4.59);
                            Console.WriteLine("2.潛水配重帶\t\t(JPY){0}", 460 * 4.59);
                            Console.WriteLine("3.潛水作業指北針\t(JPY){0}", 1100 * 4.59);
                        }
                        break;

                    case 2:
                        Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針");
                        Console.Write("輸入數字選擇商品：");
                        product = Convert.ToInt32(Console.ReadLine());
                        if (product != 1 && product != 2 && product != 3) {
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        }
                        Console.Write("輸入數量：");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        shopping_cart[product - 1] += quantity;
                        break;

                    case 3:
                        Console.WriteLine("購物車內容：");
                        Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
                        if (currency == 1) {
                            Console.WriteLine("1.潛水相機防丟繩\t(TWD){0}\t{1}\t{2}", 199, shopping_cart[0], shopping_cart[0] * 199);
                            Console.WriteLine("2.潛水配重帶\t\t(TWD){0}\t{1}\t{2}", 460, shopping_cart[1], shopping_cart[1] * 460);
                            Console.WriteLine("3.潛水作業指北針\t(TWD){0}\t{1}\t{2}", 1100, shopping_cart[2], shopping_cart[2] * 1100);
                        } else if (currency == 2) {
                            Console.WriteLine("1.潛水相機防丟繩\t(USD){0}\t{1}\t{2}", 199 * 0.031, shopping_cart[0], shopping_cart[0] * 199 * 0.031);
                            Console.WriteLine("2.潛水配重帶\t\t(USD){0}\t{1}\t{2}", 460 * 0.031, shopping_cart[1], shopping_cart[1] * 460 * 0.031);
                            Console.WriteLine("3.潛水作業指北針\t(USD){0}\t{1}\t{2}", 1100 * 0.031, shopping_cart[2], shopping_cart[2] * 1100 * 0.031);
                        } else if (currency == 3) {
                            Console.WriteLine("1.潛水相機防丟繩\t(CNY){0}\t{1}\t{2}", 199 * 0.23, shopping_cart[0], shopping_cart[0] * 199 * 0.23);
                            Console.WriteLine("2.潛水配重帶\t\t(CNY){0}\t{1}\t{2}", 105.8, shopping_cart[1], shopping_cart[1] * 105.8);
                            Console.WriteLine("3.潛水作業指北針\t(CNY){0}\t{1}\t{2}", 1100 * 0.23, shopping_cart[2], shopping_cart[2] * 1100 * 0.23);
                        } else if (currency == 4) {
                            Console.WriteLine("1.潛水相機防丟繩\t(JPY){0}\t{1}\t{2}", 199 * 4.59, shopping_cart[0], shopping_cart[0] * 199 * 4.59);
                            Console.WriteLine("2.潛水配重帶\t\t(JPY){0}\t{1}\t{2}", 460 * 4.59, shopping_cart[1], shopping_cart[1] * 460 * 4.59);
                            Console.WriteLine("3.潛水作業指北針\t(JPY){0}\t{1}\t{2}", 1100 * 4.59, shopping_cart[2], shopping_cart[2] * 1100 * 4.59);
                        }
                        Console.Write("輸入數字選擇商品：");
                        product = Convert.ToInt32(Console.ReadLine());
                        if (product != 1 && product != 2 && product != 3) {
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        }
                        Console.Write("輸入數量：");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        shopping_cart[product - 1] -= quantity;
                        Console.WriteLine("成功刪除商品!");
                        break;

                    case 4:
                        Console.WriteLine("購物車內容：");
                        Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
                        if (currency == 1) {
                            Console.WriteLine("1.潛水相機防丟繩\t(TWD){0}\t{1}\t{2}", 199, shopping_cart[0], shopping_cart[0] * 199);
                            Console.WriteLine("2.潛水配重帶\t\t(TWD){0}\t{1}\t{2}", 460, shopping_cart[1], shopping_cart[1] * 460);
                            Console.WriteLine("3.潛水作業指北針\t(TWD){0}\t{1}\t{2}", 1100, shopping_cart[2], shopping_cart[2] * 1100);
                        } else if (currency == 2) {
                            Console.WriteLine("1.潛水相機防丟繩\t(USD){0}\t{1}\t{2}", 199 * 0.031, shopping_cart[0], shopping_cart[0] * 199 * 0.031);
                            Console.WriteLine("2.潛水配重帶\t\t(USD){0}\t{1}\t{2}", 460 * 0.031, shopping_cart[1], shopping_cart[1] * 460 * 0.031);
                            Console.WriteLine("3.潛水作業指北針\t(USD){0}\t{1}\t{2}", 1100 * 0.031, shopping_cart[2], shopping_cart[2] * 1100 * 0.031);
                        } else if (currency == 3) {
                            Console.WriteLine("1.潛水相機防丟繩\t(CNY){0}\t{1}\t{2}", 199 * 0.23, shopping_cart[0], shopping_cart[0] * 199 * 0.23);
                            Console.WriteLine("2.潛水配重帶\t\t(CNY){0}\t{1}\t{2}", 105.8, shopping_cart[1], shopping_cart[1] * 105.8);
                            Console.WriteLine("3.潛水作業指北針\t(CNY){0}\t{1}\t{2}", 1100 * 0.23, shopping_cart[2], shopping_cart[2] * 1100 * 0.23);
                        } else if (currency == 4) {
                            Console.WriteLine("1.潛水相機防丟繩\t(JPY){0}\t{1}\t{2}", 199 * 4.59, shopping_cart[0], shopping_cart[0] * 199 * 4.59);
                            Console.WriteLine("2.潛水配重帶\t\t(JPY){0}\t{1}\t{2}", 460 * 4.59, shopping_cart[1], shopping_cart[1] * 460 * 4.59);
                            Console.WriteLine("3.潛水作業指北針\t(JPY){0}\t{1}\t{2}", 1100 * 4.59, shopping_cart[2], shopping_cart[2] * 1100 * 4.59);
                        }
                        break;

                    case 5:
                        sum = shopping_cart[0] * 199 + shopping_cart[1] * 460 + shopping_cart[2] * 1100;
                        Console.WriteLine("訂單商品：");
                        Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
                        if (currency == 1) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(TWD){0}\t{1}\t{2}", 199, shopping_cart[0], shopping_cart[0] * 199);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(TWD){0}\t{1}\t{2}", 460, shopping_cart[1], shopping_cart[1] * 460);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(TWD){0}\t{1}\t{2}", 1100, shopping_cart[2], shopping_cart[2] * 1100);
                            }
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 2) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(USD){0}\t{1}\t{2}", 199 * 0.031, shopping_cart[0], shopping_cart[0] * 199 * 0.031);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(USD){0}\t{1}\t{2}", 460 * 0.031, shopping_cart[1], shopping_cart[1] * 460 * 0.031);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(USD){0}\t{1}\t{2}", 1100 * 0.031, shopping_cart[2], shopping_cart[2] * 1100 * 0.031);
                            }
                            sum = (int)(sum * 0.031);
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 3) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(CNY){0}\t{1}\t{2}", 199 * 0.23, shopping_cart[0], shopping_cart[0] * 199 * 0.23);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(CNY){0}\t{1}\t{2}", 105.8, shopping_cart[1], shopping_cart[1] * 105.8);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(CNY){0}\t{1}\t{2}", 1100 * 0.23, shopping_cart[2], shopping_cart[2] * 1100 * 0.23);
                            }
                            sum = (int)(sum * 0.23);
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 4) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(JPY){0}\t{1}\t{2}", 199 * 4.59, shopping_cart[0], shopping_cart[0] * 199 * 4.59);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(JPY){0}\t{1}\t{2}", 460 * 4.59, shopping_cart[1], shopping_cart[1] * 460 * 4.59);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(JPY){0}\t{1}\t{2}", 1100 * 4.59, shopping_cart[2], shopping_cart[2] * 1100 * 4.59);
                            }
                            sum = (int)(sum * 4.59);
                            Console.WriteLine("總價 = {0}", sum);
                        }

                        Console.Write("*是否要結帳(Y/N)：");
                        ans = Console.ReadLine();
                        if (!ans.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && !ans.Equals("N", StringComparison.CurrentCultureIgnoreCase)) {
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        } else if (ans.Equals("N", StringComparison.CurrentCultureIgnoreCase)) {
                            break;
                        }

                        inventory = true;
                        if (shopping_cart[0] > 1) {
                            Console.WriteLine("潛水相機防丟繩庫存不足!剩餘數量1!");
                            inventory = false;
                        }
                        if (shopping_cart[1] > 2) {
                            Console.WriteLine("潛水配重帶庫存不足!剩餘數量2!");
                            inventory = false;
                        }
                        if (shopping_cart[2] > 1) {
                            Console.WriteLine("潛水作業指北針庫存不足!剩餘數量1!");
                            inventory = false;
                        }
                        if (inventory == false) {
                            break;
                        }

                        Console.Write("*選擇結帳方式(1.線上支付 2.貨到付款)：");
                        payment_method = Convert.ToInt32(Console.ReadLine());
                        if (payment_method != 1 && payment_method != 2) {
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        }

                        Console.Write("*折扣碼(若無折扣碼則輸入N)：");
                        discount_code = Console.ReadLine();
                        if (!discount_code.Equals("1111", StringComparison.CurrentCultureIgnoreCase) && !discount_code.Equals("N", StringComparison.CurrentCultureIgnoreCase)) {
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        }

                        Console.WriteLine("訂單狀態：");
                        Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
                        if (currency == 1) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(TWD){0}\t{1}\t{2}", 199, shopping_cart[0], shopping_cart[0] * 199);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(TWD){0}\t{1}\t{2}", 460, shopping_cart[1], shopping_cart[1] * 460);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(TWD){0}\t{1}\t{2}", 1100, shopping_cart[2], shopping_cart[2] * 1100);
                            }
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 2) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(USD){0}\t{1}\t{2}", 199 * 0.031, shopping_cart[0], shopping_cart[0] * 199 * 0.031);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(USD){0}\t{1}\t{2}", 460 * 0.031, shopping_cart[1], shopping_cart[1] * 460 * 0.031);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(USD){0}\t{1}\t{2}", 1100 * 0.031, shopping_cart[2], shopping_cart[2] * 1100 * 0.031);
                            }
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 3) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(CNY){0}\t{1}\t{2}", 199 * 0.23, shopping_cart[0], shopping_cart[0] * 199 * 0.23);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(CNY){0}\t{1}\t{2}", 105.8, shopping_cart[1], shopping_cart[1] * 105.8);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(CNY){0}\t{1}\t{2}", 1100 * 0.23, shopping_cart[2], shopping_cart[2] * 1100 * 0.23);
                            }
                            Console.WriteLine("總價 = {0}", sum);
                        } else if (currency == 4) {
                            if (shopping_cart[0] > 0) {
                                Console.WriteLine("潛水相機防丟繩\t\t(JPY){0}\t{1}\t{2}", 199 * 4.59, shopping_cart[0], shopping_cart[0] * 199 * 4.59);
                            }
                            if (shopping_cart[1] > 0) {
                                Console.WriteLine("潛水配重帶\t\t(JPY){0}\t{1}\t{2}", 460 * 4.59, shopping_cart[1], shopping_cart[1] * 460 * 4.59);
                            }
                            if (shopping_cart[2] > 0) {
                                Console.WriteLine("潛水作業指北針\t\t(JPY){0}\t{1}\t{2}", 1100 * 4.59, shopping_cart[2], shopping_cart[2] * 1100 * 4.59);
                            }
                            Console.WriteLine("總價 = {0}", sum);
                        }
                        if (discount_code.Equals("1111", StringComparison.CurrentCultureIgnoreCase)) {
                            sum = (int)(sum * 0.95);
                            Console.WriteLine("總價(折扣後) = {0}", sum);
                        }
                        if (payment_method == 1) {
                            Console.WriteLine("狀態：已付款");
                        } else if (payment_method == 2) {
                            Console.WriteLine("狀態：尚未付款");
                        }
                        end = true;
                        break;

                    case 6:
                        Console.Write("選擇貨幣 1.TWD 2.USD 3.CNY 4.JPY：");
                        int tmp = currency;
                        currency = Convert.ToInt32(Console.ReadLine());
                        if (currency != 1 && currency != 2 && currency != 3 && currency != 4) {
                            currency = tmp;
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                        }
                        break;

                    case 7:
                        end = true;
                        break;

                    default:
                        Console.WriteLine("輸入錯誤!請重新輸入!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}