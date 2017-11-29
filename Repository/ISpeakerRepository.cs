using System;
using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
=======
using AspNetCore203.Models;

namespace AspNetCore203.Repository {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public interface ISpeakerRepository {
        Task<IEnumerable<Speaker>> GetSpeakerAsync ();
        Task<Speaker> GetSpeakerAsync (Guid speakerId);
        Task<Speaker> InsertSpeaker (Speaker speaker);
        Task<bool> UpdateSpeaker (Speaker speaker);
        Task<bool> DelateSpeaker (Guid speakerId);
        Task<bool> SpeakerExist (Guid speakerId);
        Task<bool> SaveSpeakerAsync ();
    }
}