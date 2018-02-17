package outsystems.nosmusicdbexternaldata.actions;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.records.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.runtimepublic.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.log.*;
import java.math.BigDecimal;

public class ActGetSocialMediaDataPointByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param inParamSocialMediaId
	 * @param inParamDataPointTypeId
	 * @param inParamCountryId
	 * @param result.outParamDataPoint
	 **/
	public static ActGetSocialMediaDataPointByArtist mosGetSocialMediaDataPointByArtist(int inParamArtistId, int inParamSocialMediaId, int inParamDataPointTypeId, int inParamCountryId) {
		ActGetSocialMediaDataPointByArtist result = new ActGetSocialMediaDataPointByArtist();
		result.outParamDataPoint = new RCt_SMArtistDataPointRecord();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RCt_SMArtistDataPointRecord outParamDataPoint;

}
