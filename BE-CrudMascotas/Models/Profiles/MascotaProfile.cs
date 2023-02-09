using AutoMapper;
using BE_CrudMascotas.Models.DTO;

namespace BE_CrudMascotas.Models.Profiles
{
    public class MascotaProfile: Profile
    {
        public MascotaProfile()
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
        }
    }
}
