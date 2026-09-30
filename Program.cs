using QuanLySinhVien.Models;

List<Student> students = new List<Student>();

while (true)
{
    Console.Clear();
    Console.WriteLine(" QUAN LY SINH VIEN");
    Console.WriteLine("1. Them sinh vien");
    Console.WriteLine("2. Hien thi danh sach");
    Console.WriteLine("3. Tim sinh vien");
    Console.WriteLine("4. Sua sinh vien");
    Console.WriteLine("5. Xoa sinh vien");
    Console.WriteLine("0. Thoat");

    Console.Write("Chon chuc nang: ");
    string choice = Console.ReadLine()!;

    switch (choice)
    {
   
        // 1. THEM SINH VIEN
 
        case "1":
            {
                Console.WriteLine("\n===== THEM SINH VIEN =====");

                Console.Write("Nhap ID: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Nhap ho ten: ");
                string fullName = Console.ReadLine()!;

                Console.Write("Nhap lop: ");
                string className = Console.ReadLine()!;

                Console.Write("Nhap diem: ");
                double score = double.Parse(Console.ReadLine()!);

                Student student = new Student();

                student.Id = id;
                student.FullName = fullName;
                student.ClassName = className;
                student.Score = score;

                students.Add(student);

                Console.WriteLine("\nThem sinh vien thanh cong!");

                break;
            }
            

        
        // 2. HIEN THI DANH SACH
        
        case "2":
            {
                Console.WriteLine("\n===== DANH SACH SINH VIEN =====");

                if (students.Count == 0)
                {
                    Console.WriteLine("Danh sach sinh vien dang rong.");
                }
                else
                {
                    foreach (Student s in students)
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("ID       : " + s.Id);
                        Console.WriteLine("Ho ten   : " + s.FullName);
                        Console.WriteLine("Lop      : " + s.ClassName);
                        Console.WriteLine("Diem     : " + s.Score);
                    }

                    Console.WriteLine("-------------------------------");
                }

                break;
            }

        
        // 3. TIM SINH VIEN
        
        case "3":
            {
                Console.WriteLine("\n===== TIM SINH VIEN =====");

                Console.Write("Nhap ten sinh vien can tim: ");
                string keyword = Console.ReadLine()!;

                bool found = false;

                foreach (Student s in students)
                {
                    if (s.FullName.Contains(
                        keyword,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("ID       : " + s.Id);
                        Console.WriteLine("Ho ten   : " + s.FullName);
                        Console.WriteLine("Lop      : " + s.ClassName);
                        Console.WriteLine("Diem     : " + s.Score);

                        found = true;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine("Khong tim thay sinh vien.");
                }

                break;
            }

        
        // 4. SUA SINH VIEN
        
        case "4":
            {
                Console.WriteLine("\n===== SUA SINH VIEN =====");

                Console.Write("Nhap ID sinh vien can sua: ");
                int updateId = int.Parse(Console.ReadLine()!);

                Student? studentToUpdate = null;

                foreach (Student s in students)
                {
                    if (s.Id == updateId)
                    {
                        studentToUpdate = s;
                        break;
                    }
                }

                if (studentToUpdate == null)
                {
                    Console.WriteLine("Khong tim thay sinh vien.");
                }
                else
                {
                    Console.WriteLine("\nThong tin hien tai:");
                    Console.WriteLine("Ho ten : " + studentToUpdate.FullName);
                    Console.WriteLine("Lop    : " + studentToUpdate.ClassName);
                    Console.WriteLine("Diem   : " + studentToUpdate.Score);

                    Console.WriteLine("\nNhap thong tin moi:");

                    Console.Write("Nhap ho ten moi: ");
                    studentToUpdate.FullName = Console.ReadLine()!;

                    Console.Write("Nhap lop moi: ");
                    studentToUpdate.ClassName = Console.ReadLine()!;

                    Console.Write("Nhap diem moi: ");
                    studentToUpdate.Score = double.Parse(Console.ReadLine()!);

                    Console.WriteLine("\nSua sinh vien thanh cong!");
                }

                break;
            }

        
        // 5. XOA SINH VIEN
        
        case "5":
            {
                Console.WriteLine("\n===== XOA SINH VIEN =====");

                Console.Write("Nhap ID sinh vien can xoa: ");
                int deleteId = int.Parse(Console.ReadLine()!);

                Student? studentToDelete = null;

                foreach (Student s in students)
                {
                    if (s.Id == deleteId)
                    {
                        studentToDelete = s;
                        break;
                    }
                }

                if (studentToDelete == null)
                {
                    Console.WriteLine("Khong tim thay sinh vien.");
                }
                else
                {
                    students.Remove(studentToDelete);

                    Console.WriteLine("\nXoa sinh vien thanh cong!");
                }

                break;
            }

        
        // 0. THOAT
        
        case "0":
            {
                Console.WriteLine("\nDa thoat chuong trinh.");
                return;
            }

        
        // NHAP SAI
        
        default:
            {
                Console.WriteLine("\nLua chon khong hop le!");
                break;
            }
    }

    Console.WriteLine("\nNhan Enter de quay lai menu...");
    Console.ReadLine();
}
