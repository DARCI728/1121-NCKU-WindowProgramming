namespace GhostHidingGame {
    class Program {
        public static void PrintSpace(ref string[,] space) {
            for (int i = 0; i < space.GetLength(0) + 1; i++) {
                for (int j = 0; j < space.GetLength(1) + 1; j++) {
                    if (i == 0 && j > 0) {
                        Console.Write(((char)(j + 64)).ToString());
                    } else if (i > 0 && j == 0) {
                        Console.Write((i - 1).ToString());
                    } else if (i > 0 && j > 0) {
                        if (space[i - 1, j - 1] == null) {
                            Console.Write("-");
                        } else {
                            Console.Write("{0}", space[i - 1, j - 1]);
                        }
                    } else {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        public static void CompleteAnsSpace(ref string[,] space, ref string[,] ans_space, int row, int colum, int num_of_ghosts) {
            Console.Clear();
            PrintSpace(ref space);

            int x, y;
            while (true) {
                Console.Write("輸入要查看的位置: ");
                string[] str = Console.ReadLine().Split(',');
                x = int.Parse(str[0]);
                y = (int)(str[1][0]) - 65;
                if (0 > x || x >= space.GetLength(0) || 0 > y || y >= space.GetLength(1)) {
                    Console.WriteLine("無效的輸入，請再試一次");
                } else {
                    break;
                }
            }

            int ghosts = 0;
            int[] ghosts_arr = new int[num_of_ghosts];
            var rand = new Random();
            while (ghosts != num_of_ghosts) {
                int num = rand.Next(0, row * colum);
                if ((!ghosts_arr.Contains(num) || num == 0) && num != x * colum + y) {
                    ans_space[num / colum, num % colum] = "X";
                    ghosts_arr[ghosts++] = num;
                }
            }

            if (row > 1 && colum > 1) {
                int i, j, k;
                for (i = 0; i < row; i++) {
                    for (j = 0; j < colum; j++) {
                        int times = 0, ghosts_arround = 0;
                        int num = i * colum + j;
                        int[] arr = new int[] { };

                        if (ans_space[i, j] == "X") {
                            continue;
                        }

                        if ((0 < i && i < row - 1) && (0 < j && j < colum - 1)) {
                            arr = new int[] { -colum - 1, -colum, -colum + 1, -1, 1, colum - 1, colum, colum + 1 };
                            times = 8;
                        } else if (i == 0 && (0 < j && j < colum - 1)) {
                            arr = new int[] { -1, 1, colum - 1, colum, colum + 1 };
                            times = 5;
                        } else if (i == row - 1 && (0 < j && j < colum - 1)) {
                            arr = new int[] { -colum - 1, -colum, -colum + 1, -1, 1 };
                            times = 5;
                        } else if ((0 < i && i < row - 1) && j == 0) {
                            arr = new int[] { -colum, -colum + 1, 1, colum, colum + 1 };
                            times = 5;
                        } else if ((0 < i && i < row - 1) && j == colum - 1) {
                            arr = new int[] { -colum - 1, -colum, -1, colum - 1, colum, };
                            times = 5;
                        } else if (i == 0 && j == 0) {
                            arr = new int[] { 1, colum, colum + 1 };
                            times = 3;
                        } else if (i == 0 && j == colum - 1) {
                            arr = new int[] { -1, colum - 1, colum };
                            times = 3;
                        } else if (i == row - 1 && j == 0) {
                            arr = new int[] { -colum, -colum + 1, 1 };
                            times = 3;
                        } else if (i == row - 1 && j == colum - 1) {
                            arr = new int[] { -colum - 1, -colum, -1 };
                            times = 3;
                        }

                        for (k = 0; k < times; k++) {
                            if (ans_space[(num + arr[k]) / colum, (num + arr[k]) % colum] == "X") {
                                ghosts_arround++;
                            }
                        }
                        ans_space[i, j] = ghosts_arround.ToString();
                    }
                }
            } else {
                int i;
                if (num_of_ghosts == 0) {
                    for (i = 0; i < row; i++) {
                        for (i = 0; i < colum; i++) {
                            ans_space[i, i] = "0";
                        }
                    }
                }

                if (row == 1) {
                    if (ans_space[0, 0] != "X" && ans_space[0, 1] == "X") {
                        ans_space[0, 0] = "1";
                    } else if (ans_space[0, 0] != "X" && ans_space[0, 1] != "X") {
                        ans_space[0, 0] = "0";
                    }

                    if (ans_space[0, colum - 1] != "X" && ans_space[0, colum - 2] == "X") {
                        ans_space[0, colum - 1] = "1";
                    } else if (ans_space[0, colum - 1] != "X" && ans_space[0, colum - 2] != "X") {
                        ans_space[0, colum - 1] = "0";
                    }

                    for (i = 1; i < colum - 1; i++) {
                        if (ans_space[0, i] != "X") {
                            if (ans_space[0, i + 1] == "X" && ans_space[0, i - 1] == "X") {
                                ans_space[0, i] = "2";
                            } else if ((ans_space[0, i + 1] != "X" && ans_space[0, i - 1] == "X") || (ans_space[0, i + 1] == "X" && ans_space[0, i - 1] != "X")) {
                                ans_space[0, i] = "1";
                            } else if (ans_space[0, i + 1] != "X" && ans_space[0, i - 1] != "X") {
                                ans_space[0, i] = "0";
                            }
                        }
                    }
                }

                if (colum == 1) {
                    if (ans_space[0, 0] != "X" && ans_space[1, 0] == "X") {
                        ans_space[0, 0] = "1";
                    } else if (ans_space[0, 0] != "X" && ans_space[1, 0] != "X") {
                        ans_space[0, 0] = "0";
                    }

                    if (ans_space[row - 1, 0] != "X" && ans_space[row - 2, 0] == "X") {
                        ans_space[row - 1, 0] = "1";
                    } else if (ans_space[0, row - 1] != "X" && ans_space[row - 2, 0] != "X") {
                        ans_space[row - 1, 0] = "0";
                    }

                    for (i = 1; i < row - 1; i++) {
                        if (ans_space[i, 0] != "X") {
                            if (ans_space[i + 1, 0] == "X" && ans_space[i - 1, 0] == "X") {
                                ans_space[i, 0] = "2";
                            } else if ((ans_space[i + 1, 0] != "X" && ans_space[i - 1, 0] == "X") || (ans_space[i + 1, 0] == "X" && ans_space[i - 1, 0] != "X")) {
                                ans_space[i, 0] = "1";
                            } else if (ans_space[i + 1, 0] != "X" && ans_space[i - 1, 0] != "X") {
                                ans_space[i, 0] = "0";
                            }
                        }
                    }
                }

            }

            space[x, y] = ans_space[x, y];
        }

        public static void PlayingGame(ref string[,] space, ref string[,] ans_space, ref int win, int num_of_ghosts) {
            Console.Clear();

            if (win == 0) {
                Console.Clear();
                PrintSpace(ref ans_space);
                Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
                return;
            }

            PrintSpace(ref space);

            int x, y;
            while (true) {
                Console.Write("輸入要查看的位置: ");
                string[] str = Console.ReadLine().Split(',');
                x = int.Parse(str[0]);
                y = (int)(str[1][0]) - 65;
                if (0 > x || x >= space.GetLength(0) || 0 > y || y >= space.GetLength(1) || space[x, y] != null) {
                    Console.WriteLine("無效的輸入，請再試一次");
                } else {
                    break;
                }
            }

            if (ans_space[x, y] != "X") {
                win--;

                space[x, y] = ans_space[x, y];
                PlayingGame(ref space, ref ans_space, ref win, num_of_ghosts);
            } else {
                Console.Clear();
                PrintSpace(ref ans_space);
                Console.WriteLine("遊戲結束! 你被鬼抓到了");
            }
        }

        static void Main(string[] args) {
            int row, colum, num_of_ghosts;
            string[] str;

            Console.WriteLine("設定遊戲參數");
            Console.Write("輸入空間的大小: ");
            str = Console.ReadLine().Split(',');
            row = int.Parse(str[0]);
            colum = int.Parse(str[1]);
            Console.Write("輸入鬼的數量: ");
            num_of_ghosts = int.Parse(Console.ReadLine());
            if (0 > num_of_ghosts || num_of_ghosts >= row * colum) {
                Console.WriteLine("遊戲參數錯誤!");
                return;
            }

            int win = row * colum - num_of_ghosts - 1;
            string[,] space = new string[row, colum];
            string[,] ans_space = new string[row, colum];

            CompleteAnsSpace(ref space, ref ans_space, row, colum, num_of_ghosts);
            PlayingGame(ref space, ref ans_space, ref win, num_of_ghosts);
        }
    }
}
