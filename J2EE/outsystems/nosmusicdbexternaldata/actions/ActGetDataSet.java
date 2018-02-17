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

public class ActGetDataSet {

	/**
	 *
	 * @param inParamDataSetId
	 * @param inParamVersion
	 * @param result.outParamDataSet
	 **/
	public static ActGetDataSet mosGetDataSet(long inParamDataSetId, int inParamVersion) {
		ActGetDataSet result = new ActGetDataSet();
		result.outParamDataSet = new RCt_STDataSetRecord();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RCt_STDataSetRecord outParamDataSet;

}
