using System;

public class MathAssignment : Assignment // o :Assigment significa que o mathassigment esta herdando do assignment 
{
    private string _section;
    private string _problems;

    //aqui ele vai chamar o construtor da classe base para inciar, isso vai evitar a duplicacao
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }

}