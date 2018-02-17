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

public class ActGetArtistCorrelation {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistCorrelation
	 **/
	public static ActGetArtistCorrelation mosGetArtistCorrelation(int inParamArtistId) {
		ActGetArtistCorrelation result = new ActGetArtistCorrelation();
		result.outParamArtistCorrelation = new RLt_MUArtistCorrelationRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MUArtistCorrelationRecordList outParamArtistCorrelation;

}
