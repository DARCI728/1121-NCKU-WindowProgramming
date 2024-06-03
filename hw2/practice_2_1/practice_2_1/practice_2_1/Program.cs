namespace GradeCalculator {
    class Program {
        public static void sort(ref string[][] transcript) {
            Array.Sort(transcript, (x, y) => {
                if (x[1] != null && y[1] != null) {
                    return int.Parse(y[1]) - int.Parse(x[1]);
                } else if (x[1] == null && y[1] != null) {
                    return 1;
                } else if (x[1] != null && y[1] == null) {
                    return -1;
                } else {
                    return 0;
                }
            });
        }

        public static void AddNewSubjects(ref string[] keywords, ref string[][] transcript) {
            for (int i = 0; i < 100; i++) {
                if (transcript[i][0] != null && keywords[1] == transcript[i][0]) {
                    Console.WriteLine("科目已存在\n");
                    return;
                }
            }

            int score = int.Parse(keywords[2]);
            string credits = keywords[3];
            string old_GPA = "", new_GPA = "";

            int[] upperBound = { 100, 89, 84, 79, 76, 72, 69, 66, 62, 59, 50 };
            int[] lowerBound = { 90, 85, 80, 77, 73, 70, 67, 63, 60, 50, 0 };
            string[] rank = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "F", "F" };
            string[] old_GPA_arr = { "4.0", "4.0", "4.0", "3.0", "3.0", "3.0", "2.0", "2.0", "2.0", "1.0", "0.0" };
            string[] new_GPA_arr = { "4.3", "4.0", "3.7", "3.3", "3.0", "2.7", "2.3", "2.0", "1.7", "0.0", "0.0" };

            for (int i = 0; i < 11; i++) {
                if (upperBound[i] >= score && score >= lowerBound[i]) {
                    keywords[3] = rank[i];
                    old_GPA = old_GPA_arr[i];
                    new_GPA = new_GPA_arr[i];
                    break;
                }
            }

            for (int i = 0; i < 100; i++) {
                if (transcript[i][0] == null) {
                    for (int j = 0; j < 3; j++) {
                        transcript[i][j] = keywords[j + 1];
                    }
                    transcript[i][3] = credits;
                    transcript[i][4] = old_GPA;
                    transcript[i][5] = new_GPA;
                    Console.WriteLine("科目已新增\n");
                    return;
                }
            }
        }

        public static void DeleteAccounts(ref string[] keywords, ref string[][] transcript) {
            for (int i = 0; i < 100; i++) {
                if (transcript[i][0] != null && keywords[1] == transcript[i][0]) {
                    Array.Clear(transcript[i]);
                    Console.WriteLine("科目已刪除\n");
                    return;
                }
            }
            Console.WriteLine("科目不存在\n");
        }

        public static void UpdateAccounts(ref string[] keywords, ref string[][] transcript) {
            for (int i = 0; i < 100; i++) {
                if (transcript[i][0] != null && keywords[1] == transcript[i][0]) {
                    int score = int.Parse(keywords[2]);
                    string credits = keywords[3];
                    string old_GPA = "", new_GPA = "";

                    int[] upperBound = { 100, 89, 84, 79, 76, 72, 69, 66, 62, 59, 50 };
                    int[] lowerBound = { 90, 85, 80, 77, 73, 70, 67, 63, 60, 50, 0 };
                    string[] rank = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "F", "F" };
                    string[] old_GPA_arr = { "4.0", "4.0", "4.0", "3.0", "3.0", "3.0", "2.0", "2.0", "2.0", "1.0", "0.0" };
                    string[] new_GPA_arr = { "4.3", "4.0", "3.7", "3.3", "3.0", "2.7", "2.3", "2.0", "1.7", "0.0", "0.0" };

                    for (int j = 0; j < 11; j++) {
                        if (upperBound[j] >= score && score >= lowerBound[j]) {
                            keywords[3] = rank[j];
                            old_GPA = old_GPA_arr[j];
                            new_GPA = new_GPA_arr[j];
                            break;
                        }
                    }

                    for (int j = 0; j < 3; j++) {
                        transcript[i][j] = keywords[j + 1];
                    }

                    transcript[i][3] = credits;
                    transcript[i][4] = old_GPA;
                    transcript[i][5] = new_GPA;
                    Console.WriteLine("科目已更新\n");
                    return;
                }
            }
            Console.WriteLine("科目不存在\n");
        }

        public static void PrintTranscript(ref string[][] transcript) {
            int sum_of_credits = 0, real_credits = 0;
            double sum_of_score = 0, sum_of_old_GPA = 0, sum_of_new_GPA = 0;

            sort(ref transcript);

            Console.WriteLine("\n我的成績單: ");
            Console.WriteLine("編號\t科目代碼\t分數\t等第\t學分數");
            for (int i = 0; i < 100; i++) {
                if (!String.IsNullOrEmpty(transcript[i][0])) {
                    Console.Write("{0}\t", i + 1);
                    for (int j = 0; j < 4; j++) {
                        Console.Write("{0}\t", transcript[i][j]);
                        if (j == 0) {
                            Console.Write("\t");
                        }
                    }
                    Console.Write("\n");
                    sum_of_score += int.Parse(transcript[i][1]) * int.Parse(transcript[i][3]);
                    sum_of_credits += int.Parse(transcript[i][3]);
                    sum_of_old_GPA += double.Parse(transcript[i][4]) * int.Parse(transcript[i][3]);
                    sum_of_new_GPA += double.Parse(transcript[i][5]) * int.Parse(transcript[i][3]);
                    if (int.Parse(transcript[i][1]) >= 60) {
                        real_credits += int.Parse(transcript[i][3]);
                    }
                } else {
                    Console.WriteLine("總平均: {0:##0.00}", sum_of_score / sum_of_credits);
                    Console.WriteLine("GPA: {0:0.0}/4.0 (舊制), {1:0.0}/4.3 (新制)", sum_of_old_GPA / sum_of_credits, sum_of_new_GPA / sum_of_credits);
                    Console.WriteLine("實拿學分數/總學分數: {0}/{1}\n", real_credits, sum_of_credits);
                    break;
                }
            }
        }

        static void Main(string[] args) {
            bool end = false;
            int score, credits;
            string[][] transcript = new string[100][];
            for (int i = 0; i < transcript.Length; i++) {
                transcript[i] = new string[100];
            }

            while (!end) {
                Console.WriteLine("## 成績計算器 ##");
                Console.WriteLine("1. 新增科目(create)");
                Console.WriteLine("2. 刪除科目(delete)");
                Console.WriteLine("3. 更新科目(update)");
                Console.WriteLine("4. 列印成績單(print)");
                Console.WriteLine("5. 退出選單(exit)");
                Console.Write("輸入要執行的指令操作: ");

                string command = Console.ReadLine();
                string[] keywords = command.Split(' ');

                switch (keywords[0]) {
                    case "create":
                        if (keywords.Length != 4) {
                            Console.WriteLine("指令格式不符! 請重新輸入!\n");
                            break;
                        }

                        score = int.Parse(keywords[2]);
                        credits = int.Parse(keywords[3]);

                        if (score < 0 || score > 100) {
                            Console.WriteLine("成績分數異常! 請重新輸入!\n");
                            break;
                        } else if (credits < 0 || credits > 10) {
                            Console.WriteLine("學分數異常! 請重新輸入!\n");
                            break;
                        } else {
                            AddNewSubjects(ref keywords, ref transcript);
                        }
                        break;

                    case "delete":
                        if (keywords.Length != 2) {
                            Console.WriteLine("指令格式不符! 請重新輸入!\n");
                            break;
                        } else {
                            DeleteAccounts(ref keywords, ref transcript);
                        }
                        break;

                    case "update":
                        if (keywords.Length != 4) {
                            Console.WriteLine("指令格式不符! 請重新輸入!\n");
                            break;
                        }

                        score = int.Parse(keywords[2]);
                        credits = int.Parse(keywords[3]);

                        if (score < 0 || score > 100) {
                            Console.WriteLine("成績分數異常! 請重新輸入!\n");
                            break;
                        } else if (credits < 0 || credits > 10) {
                            Console.WriteLine("學分數異常! 請重新輸入!\n");
                            break;
                        } else {
                            UpdateAccounts(ref keywords, ref transcript);
                        }
                        break;

                    case "print":
                        if (keywords.Length != 1) {
                            Console.WriteLine("指令格式不符! 請重新輸入!\n");
                            break;
                        } else {
                            PrintTranscript(ref transcript);
                        }
                        break;

                    case "exit":
                        if (keywords.Length != 1) {
                            Console.WriteLine("指令格式不符! 請重新輸入!\n");
                            break;
                        }
                        end = true;
                        Console.WriteLine("離開成績計算器");
                        break;

                    default:
                        Console.WriteLine("指令格式不符! 請重新輸入!\n");
                        break;
                }
            }
        }
    }
}