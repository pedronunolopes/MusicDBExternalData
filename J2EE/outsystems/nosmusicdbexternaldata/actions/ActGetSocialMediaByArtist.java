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

public class ActGetSocialMediaByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param inParamSocialMediaId
	 * @param result.outParamArtistSocialMedia
	 **/
	public static ActGetSocialMediaByArtist mosGetSocialMediaByArtist(int inParamArtistId, int inParamSocialMediaId) {
		ActGetSocialMediaByArtist result = new ActGetSocialMediaByArtist();
		result.outParamArtistSocialMedia = new RCt_MUArtistSocialMediaRecord();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RCt_MUArtistSocialMediaRecord outParamArtistSocialMedia;

}
