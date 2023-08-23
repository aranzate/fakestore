using FakeStore.Models;
namespace FakeStore.Services;

public static class ProfileService
{
    static List<Profile> Profiles { get; }
    static int nextId = 2;
    static ProfileService() 
    {
        Profiles = new List<Profile> 
        {
            new Profile { Id = 1, Name = "FirstUser", Wishlist = new List<Product>() }
        };
        
    }

    public static List<Profile> GetAll() => Profiles;

    public static Profile? Get(int id) => Profiles.FirstOrDefault(profile => profile.Id == id);

    public static void Add(Profile profile) 
    {
        profile.Id = nextId++;
        Profiles.Add(profile);
    }

    public static void Update(Profile profile) 
    {
        var index = Profiles.FindIndex(p => p.Id == profile.Id);
        if(index == -1)
            return;

        Profiles[index] = profile;
    }

    public static void Delete(int id) 
    {
        var profile = Get(id);
        if(profile is null)
            return;

        Profiles.Remove(profile);
    }
}