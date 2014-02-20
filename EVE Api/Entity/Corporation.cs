﻿using System;
using eZet.Eve.EveApi.Dto.EveApi;
using eZet.Eve.EveApi.Dto.EveApi.Character;
using eZet.Eve.EveApi.Dto.EveApi.Corporation;
using MedalList = eZet.Eve.EveApi.Dto.EveApi.Corporation.MedalList;
using FactionWarfareStats = eZet.Eve.EveApi.Dto.EveApi.Corporation.FactionWarfareStats;
using StandingsList = eZet.Eve.EveApi.Dto.EveApi.Corporation.StandingsList;
using ContactList = eZet.Eve.EveApi.Dto.EveApi.Corporation.ContactList;


namespace eZet.Eve.EveApi.Entity {
    public class Corporation : EveApiEntity {

        private string _corporationName;

        public string CorporationName {
            get {
                if (_corporationName == null)
                    load();
                return _corporationName;
            }
            private set { _corporationName = value; }
        }

        public long CorporationId { get; private set; }

        public long CharacterId { get; set; }

        public Corporation(ApiKey key, long characterId, long corporationId) : base(key) {
            CharacterId = characterId;
            CorporationId = corporationId;
        }

        public XmlResponse<AccountBalance> GetAccountBalance() {
            const string relPath = "/corp/AccountBalance.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new AccountBalance(), postString);
        }

        public XmlResponse<AssetList> GetAssetList() {
            const string relPath = "/corp/AssetList.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new AssetList(), postString);
        }

        public XmlResponse<ContactList> GetContactList() {
            const string relPath = "/corp/ContactList.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new ContactList(), postString);
        }

        public XmlResponse<ContainerLog> GetContainerLog() {
            const string relPath = "/corp/ContainerLog.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new ContainerLog(), postString);
        }

        public XmlResponse<ContractList> GetContracts() {
            const string relPath = "/corp/Contracts.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new ContractList(), postString);
        }

        public XmlResponse<ContractItems> GetContractItems(long contractId) {
            const string relPath = "/corp/ContractItems.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId, "contractID", contractId);
            return request(relPath, new ContractItems(), postString);
        }

        public XmlResponse<ContractBids> GetContractBids() {
            const string relPath = "/corp/ContractBids.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new ContractBids(), postString);
        }

        public XmlResponse<CorporationSheet> GetCorporationSheet() {
            const string relPath = "/corp/CorporationSheet.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey);
            return request(relPath, new CorporationSheet(), postString);
        }

        public XmlResponse<FactionWarfareStats> GetFactionWarfareStats() {
            const string relPath = "/corp/FacWarStats.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new FactionWarfareStats(), postString);
        }

        public XmlResponse<IndustryJobs> GetIndustryJobs() {
            const string relPath = "/corp/IndustryJobs.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new IndustryJobs(), postString);
        }

        public XmlResponse<KillLog> GetKillLog() {
            const string relPath = "/corp/Killlog.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new KillLog(), postString);
        }

        public XmlResponse<Locations> GetLocations(params long[] itemIds) {
            const string relPath = "/corp/Locations.xml.aspx";
            var ids = String.Join(",", itemIds);
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId, "IDs", ids);
            return request(relPath, new Locations(), postString);
        }

        public XmlResponse<MarketOrders> GetMarketOrders(long orderId = 0) {
            const string relPath = "/corp/MarketOrders.xml.aspx";
            var postString = (orderId == 0) ? RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId)
                : RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId, "orderID", orderId);
            return request(relPath, new MarketOrders(), postString);
        }

        public XmlResponse<MedalList> GetMedals() {
            const string relPath = "/corp/Medals.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new MedalList(), postString);
        }

        public XmlResponse<MemberMedals> GetMemberMedals() {
            const string relPath = "/corp/MemberMedals.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new MemberMedals(), postString);
        }

        public XmlResponse<MemberSecurity> GetMemberSecurity() {
            // TODO Rowsets
            const string relPath = "/corp/MemberSecurity.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new MemberSecurity(), postString);
        }

        public XmlResponse<MemberSecurityLog> GetMemberSecurityLog() {
            const string relPath = "/corp/MemberSecurityLog.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new MemberSecurityLog(), postString);
        }

        public XmlResponse<MemberTracking> GetMemberTracking(bool extended = false) {
            const string relPath = "/corp/MemberTracking.xml.aspx";
            var ext = extended ? 1 : 0;
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId, "extended", ext);
            return request(relPath, new MemberTracking(), postString);
        }

        public XmlResponse<OutpostList> GetOutpostList() {
            // TODO Link to OutpostServiceDetails
            const string relPath = "/corp/OutpostList.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new OutpostList(), postString);
        }

        public XmlResponse<OutpostServiceDetails> GetOutpostServiceDetails() {
            const string relPath = "/corp/OutpostServiceDetail.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new OutpostServiceDetails(), postString);
        }

        public XmlResponse<ShareholderList> GetShareholders() {
            // TODO RowSet
            const string relPath = "/corp/Shareholders.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new ShareholderList(), postString);
        }

        public XmlResponse<StandingsList> GetStandings() {
            // TODO Rowset
            const string relPath = "/corp/Standings.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new StandingsList(), postString);
        }

        public XmlResponse<StarbaseDetails> GetStarbaseDetails(long id) {
            // TODO CombatSettings
            const string relPath = "/corp/StarbaseDetail.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId, "itemID", id);
            return request(relPath, new StarbaseDetails(), postString);
        }

        public XmlResponse<StarbaseList> GetStarbaseList() {
            const string relPath = "/corp/StarbaseList.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new StarbaseList(), postString);
        }

        public XmlResponse<TitleList> GetTitles() {
            // TODO RowSet
            const string relPath = "/corp/Titles.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new TitleList(), postString);
        }

        public XmlResponse<WalletJournal> GetWalletJournal() {
            const string relPath = "/corp/WalletJournal.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new WalletJournal(), postString);
        }

        public XmlResponse<WalletTransactions> GetWalletTransactions() {
            const string relPath = "/corp/WalletTransactions.xml.aspx";
            var postString = RequestHelper.GeneratePostString(ApiKey, "characterId", CharacterId);
            return request(relPath, new WalletTransactions(), postString);
        }

        private void load() {


        }

    }
}
