using System.ComponentModel.DataAnnotations;

public class TablaEntity
{
    [Required(ErrorMessage = "Ingrese un numero valido.")]
    public int numero { get; set; }

    [Required(ErrorMessage = "Ingrese un numero valido.")]
    public int hasta { get; set; }
    public List<string> tabla { get; set; }
}