using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{


    public class Filme
    {
        [Required(ErrorMessage = "O campo 'Titulo' é obrigatório")]
        public string Titulo { get; set; }
        //
        [Required(ErrorMessage = "O campo 'Diretor' é obrigatório")]
        public string Diretor { get; set; }
        //
        [StringLength(30, ErrorMessage = "Campo 'Genero' maximo de 30 caracteres")]
        public string Genero { get; set; }
        //
        [Range(1, 600, ErrorMessage = "Duração maxima 600 minutos, minima de 1")]
        public int Duracao { get; set; }
        //
    }
}