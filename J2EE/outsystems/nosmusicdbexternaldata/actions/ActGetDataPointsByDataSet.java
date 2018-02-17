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

public class ActGetDataPointsByDataSet {

	/**
	 *
	 * @param inParamDataSetId
	 * @param inParamVersion
	 * @param result.outParamDataPoints
	 **/
	public static ActGetDataPointsByDataSet mosGetDataPointsByDataSet(long inParamDataSetId, int inParamVersion) {
		ActGetDataPointsByDataSet result = new ActGetDataPointsByDataSet();
		result.outParamDataPoints = new RLt_STDataPointRecordList();
		// TODO: Write implementation for action
		return result;
	}

	// output parameters
	public RLt_STDataPointRecordList outParamDataPoints;

}
