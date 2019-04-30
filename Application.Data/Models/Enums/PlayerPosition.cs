using System.ComponentModel.DataAnnotations;

/**
 * 
 * name         :   PlayerPosition.cs
 * author       :   Aleksy Ruszala
 * date         :   29/04/2019
 *
 * */
namespace Application.Data.Models
{
    /// <summary>
    /// the enum class represents type of position on the pitch
    /// </summary>
    public enum PlayerPosition
    {
        [Display(Name = "Good Body")]
        Loosehead,
        TightheadProp,
        Hooker,
        Lock


    }
}