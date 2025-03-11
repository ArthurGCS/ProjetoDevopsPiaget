namespace ApiPiaget.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int RGM { get; set; }
        public int CPF { get; set; } 
        public String? Materia { get; set; } 
        public Aluno? Aluno { get; set; }

    }
}