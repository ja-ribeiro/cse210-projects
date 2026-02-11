using System;

public class Assignment
{
    //aqui seria um encapsulamento
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //metodo para retornar o resumo
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // esse seria o metodo para permitir acesso ao nome do aluno, e ele um metodo publico
    public string GetStudentName()
    {
        return _studentName;
    }

}