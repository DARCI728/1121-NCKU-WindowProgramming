using System.ComponentModel.Design;

namespace MemberDataLogin {
    class MemberData {
        public string name = "";
        public string department = "";
        public string ID = "";
        public string level = "";
        public string title = "";

        public MemberData(string mbr_name, string mbr_dept, string mbr_id) {
            name = mbr_name;
            department = mbr_dept;
            ID = mbr_id;
            level = "盟新社員";
            title = "無";
        }
    }

    class Program {
        static List<MemberData> member_datas = new List<MemberData>();

        static public bool IsMemberExists(string name, string department, string ID) {
            return member_datas.Any(member => member.name == name && member.department == department && member.ID == ID);
        }

        static public bool IsTitleExists(string title) {
            return member_datas.Any(member => member.title == title);
        }

        static public void Register(string name, string department, string ID) {
            if (IsMemberExists(name, department, ID)) {
                var matchingMember = member_datas.FirstOrDefault(member => member.name == name && member.department == department && member.ID == ID);
                if (string.Equals(matchingMember.level, "盟新社員")) {
                    matchingMember.level = "資深社員";
                    Console.WriteLine("已晉升為資深社員\n");
                } else if (string.Equals(matchingMember.level, "資深社員")) {
                    matchingMember.level = "永久社員";
                    Console.WriteLine("已晉升為永久社員\n");
                } else {
                    Console.WriteLine("已經是永久社員了喔\n");
                }
            } else {
                member_datas.Add(new MemberData(name, department, ID));
                Console.WriteLine("歡迎新社員!!\n");
            }

        }

        static public void Search(string tag, string want_search_string) {
            List<MemberData> matchingMembers = new List<MemberData>();

            switch (tag) {
                case "name":
                    matchingMembers = member_datas.Where(member => member.name == want_search_string).ToList();
                    break;

                case "department":
                    matchingMembers = member_datas.Where(member => member.department == want_search_string).ToList();
                    break;

                case "ID":
                    matchingMembers = member_datas.Where(member => member.ID == want_search_string).ToList();
                    break;

                case "level":
                    matchingMembers = member_datas.Where(member => member.level == want_search_string).ToList();
                    break;

                case "title":
                    matchingMembers = member_datas.Where(member => member.title == want_search_string).ToList();
                    break;

                default:
                    break;
            }

            if (matchingMembers.Count == 0) {
                Console.WriteLine("找不到這個{0}的人ㄟ\n", tag);
            } else {
                for (int i = 0; i < matchingMembers.Count; i++) {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", matchingMembers[i].name, matchingMembers[i].department, matchingMembers[i].ID, matchingMembers[i].level, matchingMembers[i].title);
                }
                Console.WriteLine();
            }
        }

        static public void Entitle(string name, string department, string ID, string that_title) {
            if (IsMemberExists(name, department, ID)) {
                if (IsTitleExists(that_title)) {
                    var matchingMember = member_datas.FirstOrDefault(member => member.title.Contains(that_title));
                    Console.WriteLine("我們的{0}只有{1}一個人，你不要想篡位!\n", that_title, matchingMember.name);
                } else {
                    var matchingMember = member_datas.FirstOrDefault(member => member.name == name && member.department == department && member.ID == ID);
                    matchingMember.title = that_title;
                    Console.WriteLine("{0}已晉升為{1}\n", matchingMember.name, that_title);
                }
            } else {
                Console.WriteLine("找不到這個人ㄟ\n");
            }
        }

        static public void Check() {
            if (member_datas.Count > 0) {
                Console.WriteLine("----------------------------------------------------------------------------");
                for (int i = 0; i < member_datas.Count; i++) {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", member_datas[i].name, member_datas[i].department, member_datas[i].ID, member_datas[i].level, member_datas[i].title);
                }
                Console.WriteLine("----------------------------------------------------------------------------\n");
            } else {
                Console.WriteLine("社員列表為空");
            }
        }

        static public void Help() {
            Console.WriteLine("-------------------------###    社員資料登記    ###-------------------------");
            Console.WriteLine("新增社員資訊: \tregister\tname\tdepartment\tID");
            Console.WriteLine("以特定屬性查詢: search\t\ttag\twant_search_string");
            Console.WriteLine("授予社員職位: \tentitle\t\tname\tdepartment\tID\tthat_title");
            Console.WriteLine("所有社員列表: \tcheck");
            Console.WriteLine("指令格式列表: \thelp");
            Console.WriteLine("離開此程式: \texit");
            Console.WriteLine("----------------------------------------------------------------------------\n");
        }

        static void Main(string[] args) {
            bool end = false;

            Help();

            while (!end) {
                Console.Write("請輸入指令: ");
                string command = Console.ReadLine();
                string[] keywords = command.Split(' ');

                switch (keywords[0]) {
                    case "register":
                        Register(keywords[1], keywords[2], keywords[3]);
                        break;

                    case "search":
                        Search(keywords[1], keywords[2]);
                        break;

                    case "entitle":
                        Entitle(keywords[1], keywords[2], keywords[3], keywords[4]);
                        break;

                    case "check":
                        Check();
                        break;

                    case "help":
                        Help();
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("不存在這個功能，有疑慮請打help\n");
                        break;
                }
            }
        }
    }
}