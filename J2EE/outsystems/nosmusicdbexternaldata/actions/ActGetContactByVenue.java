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

public class ActGetContactByVenue {

	/**
	 *
	 * @param inParamVenueId
	 * @param result.outParamVenueContacts
	 **/
	public static ActGetContactByVenue mosGetContactByVenue(long inParamVenueId) {
		ActGetContactByVenue result = new ActGetContactByVenue();
		result.outParamVenueContacts = new RLt_VNVenueContactRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_VNVenueContactRecordList outParamVenueContacts;

}
