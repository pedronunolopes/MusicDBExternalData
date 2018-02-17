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

public class ActGetEventByArtist {

	/**
	 *
	 * @param inParamArtistId
	 * @param result.outParamArtistEvent
	 **/
	public static ActGetEventByArtist mosGetEventByArtist(int inParamArtistId) {
		ActGetEventByArtist result = new ActGetEventByArtist();
		result.outParamArtistEvent = new RLt_MUEventRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MUEventRecordList outParamArtistEvent;

}
