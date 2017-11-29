using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetcore203.Models;

namespace AspNetcore203.Repository {
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