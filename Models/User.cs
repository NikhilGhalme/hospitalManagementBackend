using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Fname { get; set; } = string.Empty;
    public string Lname { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;  // Hash passwords in real apps
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Dob { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string BloodGroup { get; set; } = string.Empty;
    public string? Specialization { get; set; }
    public string? Licences { get; set; }
    public string? Experience { get; set; }
    public string? Emcontact { get; set; }
    public string? Medhistory { get; set; }
}