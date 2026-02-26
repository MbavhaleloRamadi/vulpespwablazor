using System.ComponentModel.DataAnnotations;

namespace VulpesFormsApp.Models;

public class WeeklyQuestionnaireModel
{
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = "";

    public string Date { get; set; } = "";

    public int ReportsCompleted { get; set; }
    public List<RefCodeRow> ReportsRefCodes { get; set; } = new();

    public int SkeletonsCompleted { get; set; }
    public List<RefCodeRow> SkeletonsRefCodes { get; set; } = new();

    public int AddonsCompleted { get; set; }
    public List<RefCodeRow> AddonsRefCodes { get; set; } = new();

    public string QualityRating { get; set; } = "";
    public string DeadlineRating { get; set; } = "";
    public string ResponsivenessRating { get; set; } = "";

    [Required(ErrorMessage = "This field is required")]
    public string KeyAchievement { get; set; } = "";

    [Required(ErrorMessage = "This field is required")]
    public string Challenges { get; set; } = "";

    [Required(ErrorMessage = "This field is required")]
    public string ImprovementArea { get; set; } = "";

    [Required(ErrorMessage = "This field is required")]
    public string Suggestions { get; set; } = "";

    public string SignatureBase64 { get; set; } = "";
}

public class RefCodeRow
{
    public string VulpesRefCode { get; set; } = "";
}