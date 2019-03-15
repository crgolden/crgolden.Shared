﻿namespace Clarity.Shared
{
    public enum EventIds
    {
        IndexStart,
        IndexEnd,
        IndexError,
        DetailsStart,
        DetailsNotFound,
        DetailsEnd,
        DetailsError,
        CreateStart,
        CreateEnd,
        CreateError,
        CreateRangeStart,
        CreateRangeEnd,
        CreateRangeError,
        EditStart,
        EditEnd,
        EditError,
        EditRangeStart,
        EditRangeEnd,
        EditRangeError,
        DeleteStart,
        DeleteEnd,
        DeleteError,
        UploadStart,
        UploadEnd,
        UploadError,
        RemoveStart,
        RemoveEnd,
        RemoveError,
        ValidateStart,
        ValidateEnd,
        ValidateError,
        QueueClientStart,
        QueueClientStop,
        QueueClientProcessing,
        QueueClientCompleted,
        QueueClientError
    }
}
