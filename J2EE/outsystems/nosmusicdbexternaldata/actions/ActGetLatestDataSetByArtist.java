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

public class ActGetLatestDataSetByArtist {
	public RCt_STDataSetRecord outParamArtistDataSet;

	/**
	 *
	 * @param inParamArtistId
	 * @param inParamDataSetTypeId
	 * @param inParamArtistDataSet
	 **/
	public static ActGetLatestDataSetByArtist mosGetLatestDataSetByArtist(int inParamArtistId, int inParamDataSetTypeId) {
		ActGetLatestDataSetByArtist result = new ActGetLatestDataSetByArtist();
		// TODO: Write implementation for action
		return result;
	}

}
