﻿using Dopamine.Data.Metadata;
using Dopamine.Services.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dopamine.Services.Metadata
{
    public interface IMetadataService
    {
        Task UpdateTrackRatingAsync(string path, int rating);

        Task UpdateTrackLoveAsync(string path, bool love);

        Task UpdateTracksAsync(IList<IFileMetadata> fileMetadatas, bool updateAlbumArtwork);

        Task UpdateAlbumAsync(AlbumViewModel albumViewModel, MetadataArtworkValue artwork, bool updateFileArtwork);

        IFileMetadata GetFileMetadata(string path);

        Task<IFileMetadata> GetFileMetadataAsync(string path);

        Task<byte[]> GetArtworkAsync(string path, int size = 0);
        
        Task ForceSaveFileMetadataAsync();

        event Action<MetadataChangedEventArgs> MetadataChanged;
        event Action<RatingChangedEventArgs> RatingChanged;
        event Action<LoveChangedEventArgs> LoveChanged;
    }
}
