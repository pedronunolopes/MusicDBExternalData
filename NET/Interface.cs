using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssMusicDBExternalData {

	public interface IssMusicDBExternalData {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssArtistEvent"></param>
		void MssGetEventByArtist(int ssArtistId, out RLt_MUEventRecordList ssArtistEvent);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssArtistAlbum"></param>
		void MssGetAlbumByArtist(int ssArtistId, out RLt_MUAlbumRecordList ssArtistAlbum);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssArtistSong"></param>
		void MssGetSongByArtist(int ssArtistId, out RLt_MUSongRecordList ssArtistSong);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssArtistMusicStyle"></param>
		void MssGetMusicStyleByArtist(int ssArtistId, out RLt_MDMusicStyleRecordList ssArtistMusicStyle);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssSocialMediaId"></param>
		/// <param name="ssDataPointTypeId"></param>
		/// <param name="ssCountryId"></param>
		/// <param name="ssDataPoint"></param>
		void MssGetSocialMediaDataPointByArtist(int ssArtistId, int ssSocialMediaId, int ssDataPointTypeId, int ssCountryId, out RCt_SMArtistDataPointRecord ssDataPoint);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssArtistCorrelation"></param>
		void MssGetArtistCorrelation(int ssArtistId, out RLt_MUArtistCorrelationRecordList ssArtistCorrelation);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssSocialMediaId"></param>
		/// <param name="ssArtistSocialMedia"></param>
		void MssGetSocialMediaByArtist(int ssArtistId, int ssSocialMediaId, out RCt_MUArtistSocialMediaRecord ssArtistSocialMedia);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPromoterId"></param>
		/// <param name="ssPromoterContacts"></param>
		void MssGetContactByPromoter(int ssPromoterId, out RLt_MGPromoterContactRecordList ssPromoterContacts);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssFestivalId"></param>
		/// <param name="ssFestivalContacts"></param>
		void MssGetContactByFestival(int ssFestivalId, out RLt_MGFestivalContactRecordList ssFestivalContacts);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssVenueId"></param>
		/// <param name="ssVenueContacts"></param>
		void MssGetContactByVenue(long ssVenueId, out RLt_VNVenueContactRecordList ssVenueContacts);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDataSetId"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssDataPoints"></param>
		void MssGetDataPointsByDataSet(long ssDataSetId, int ssVersion, out RLt_STDataPointRecordList ssDataPoints);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssArtistId"></param>
		/// <param name="ssDataSetTypeId"></param>
		/// <param name="ssArtistDataSet"></param>
		void MssGetLatestDataSetByArtist(int ssArtistId, int ssDataSetTypeId, out RCt_STDataSetRecord ssArtistDataSet);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssDataSetId"></param>
		/// <param name="ssVersion"></param>
		/// <param name="ssDataSet"></param>
		void MssGetDataSet(long ssDataSetId, int ssVersion, out RCt_STDataSetRecord ssDataSet);

	} // IssMusicDBExternalData

} // OutSystems.NssMusicDBExternalData
