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

public class ActGetContactByFestival {

	/**
	 *
	 * @param inParamFestivalId
	 * @param result.outParamFestivalContacts
	 **/
	public static ActGetContactByFestival mosGetContactByFestival(int inParamFestivalId) {
		ActGetContactByFestival result = new ActGetContactByFestival();
		result.outParamFestivalContacts = new RLt_MGFestivalContactRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MGFestivalContactRecordList outParamFestivalContacts;

}
