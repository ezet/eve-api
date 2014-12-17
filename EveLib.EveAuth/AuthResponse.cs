﻿using Newtonsoft.Json;

namespace eZet.EveLib.EveAuthModule {
    [JsonObject(MemberSerialization.OptOut)]
    public class AuthResponse {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}