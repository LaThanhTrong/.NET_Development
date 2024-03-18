class Student
{
    public Student(Student student)
    {
        MaSV = student.MaSV;
        TenSV = student.TenSV;
        Phai = student.Phai;
        Lop = student.Lop;
    }
    public Student(string maSV, string tenSV, int phai, string lop)
    {
        MaSV = maSV;
        TenSV = tenSV;
        Phai = phai;
        Lop = lop;
    }
    public string MaSV { get; set; }
    public string TenSV { get; set; }
    public int Phai { get; set; }
    public string Lop { get; set; }
}