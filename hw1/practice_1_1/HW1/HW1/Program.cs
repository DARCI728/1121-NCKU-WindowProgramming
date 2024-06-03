int end = 0, product, quantity;
int[] shopping_cart = new int[3];
while (end == 0) {
    Console.WriteLine("(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4)查看購物車 (5)計算總金額 (6)退出網站");
    Console.Write("請輸入數字選擇功能：");
    if (!int.TryParse(Console.ReadLine(), out int functiion)) { }
    Console.WriteLine();
    switch (functiion) {
        case 1:
            Console.WriteLine("列表：");
            Console.WriteLine("商品名稱\t\t商品單價");
            Console.WriteLine("1.潛水相機防丟繩\t(TWD)199");
            Console.WriteLine("2.潛水配重帶\t\t(TWD)460");
            Console.WriteLine("3.潛水作業指北針\t(TWD)1100");
            break;

        case 2:
            Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針");
            Console.Write("輸入數字選擇商品：");
            if (!int.TryParse(Console.ReadLine(), out product)) { }
            if (product < 1 || product > 3) {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                break;
            }
            Console.Write("輸入數量：");
            if (!int.TryParse(Console.ReadLine(), out quantity)) { }
            shopping_cart[product - 1] += quantity;
            break;

        case 3:
            Console.WriteLine("購物車內容：");
            Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
            Console.WriteLine("1.潛水相機防丟繩\t(TWD)199\t{0}\t{1}", shopping_cart[0], shopping_cart[0] * 199);
            Console.WriteLine("2.潛水配重帶\t\t(TWD)460\t{0}\t{1}", shopping_cart[1], shopping_cart[1] * 460);
            Console.WriteLine("3.潛水作業指北針\t(TWD)1100\t{0}\t{1}", shopping_cart[2], shopping_cart[2] * 1100);
            Console.Write("輸入數字選擇商品：");
            if (!int.TryParse(Console.ReadLine(), out product)) { }
            if (product < 1 || product > 3) {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                break;
            }
            Console.Write("輸入數量：");
            if (!int.TryParse(Console.ReadLine(), out quantity)) { }
            shopping_cart[product - 1] -= quantity;
            Console.WriteLine("成功刪除商品!");
            break;

        case 4:
            Console.WriteLine("購物車內容：");
            Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
            Console.WriteLine("1.潛水相機防丟繩\t(TWD)199\t{0}\t{1}", shopping_cart[0], shopping_cart[0] * 199);
            Console.WriteLine("2.潛水配重帶\t\t(TWD)460\t{0}\t{1}", shopping_cart[1], shopping_cart[1] * 460);
            Console.WriteLine("3.潛水作業指北針\t(TWD)1100\t{0}\t{1}", shopping_cart[2], shopping_cart[2] * 1100);
            break;

        case 5:
            Console.WriteLine("訂單商品：");
            Console.WriteLine("商品名稱\t\t商品單價\t數量\t小計");
            if (shopping_cart[0] > 0) {
                Console.WriteLine("潛水相機防丟繩\t\t(TWD)199\t{0}\t{1}", shopping_cart[0], shopping_cart[0] * 199);
            }
            if (shopping_cart[1] > 0) {
                Console.WriteLine("潛水配重帶\t\t(TWD)460\t{0}\t{1}", shopping_cart[1], shopping_cart[1] * 460);
            }
            if (shopping_cart[2] > 0) {
                Console.WriteLine("潛水作業指北針\t\t(TWD)1100\t{0}\t{1}", shopping_cart[2], shopping_cart[2] * 1100);
            }
            Console.WriteLine("總價 = {0}", shopping_cart[0] * 199 + shopping_cart[1] * 460 + shopping_cart[2] * 1100);
            break;

        case 6:
            end = 1;
            break;

        default:
            Console.WriteLine("輸入錯誤!請重新輸入!");
            break;
    }
    Console.WriteLine();
}
