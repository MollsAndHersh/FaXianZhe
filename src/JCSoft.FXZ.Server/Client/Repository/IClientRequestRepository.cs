﻿using FXZServer.Values;
using Microsoft.Extensions.Caching.Memory;

namespace FXZServer.Client.Repository
{
    public interface IClientRequestRepository
    {
        ClientRequest GetRequest();

        void AddRequest(ClientRequest request);

        void UpdateRequest(ClientRequest request);
    }
}
