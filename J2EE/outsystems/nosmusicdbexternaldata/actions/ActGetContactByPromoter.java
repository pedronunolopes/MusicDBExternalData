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

public class ActGetContactByPromoter {

	/**
	 *
	 * @param inParamPromoterId
	 * @param result.outParamPromoterContacts
	 **/
	public static ActGetContactByPromoter mosGetContactByPromoter(int inParamPromoterId) {
		ActGetContactByPromoter result = new ActGetContactByPromoter();
		result.outParamPromoterContacts = new RLt_MGPromoterContactRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_MGPromoterContactRecordList outParamPromoterContacts;

}
