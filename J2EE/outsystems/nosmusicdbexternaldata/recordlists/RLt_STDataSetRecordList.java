package outsystems.nosmusicdbexternaldata.recordlists;

import java.sql.*;
import java.io.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.ADOTransaction;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.hubedition.util.delegates.*;
import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.records.*;


/**
 *
 * RecordList type <code>RLt_STDataSetRecordList</code> that represents a record list of
 *  <code>t_STDataSet</code>
 */
public class RLt_STDataSetRecordList extends GenericRecordList<RCt_STDataSetRecord> {
	public static void ensureInitialized() {}

	protected RCt_STDataSetRecord getElementDefaultValue() {
		return new RCt_STDataSetRecord();
	}

	public <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, Func.Func1<RCt_STDataSetRecord, T> converter) {
		return toArray(methodTypeArg_T, this, converter);
	}

	public static <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, RLt_STDataSetRecordList recordlist, Func.Func1<RCt_STDataSetRecord, T> converter) {
		try {
			return innerToArray(TypeInformation.get(RCt_STDataSetRecord.class), methodTypeArg_T, recordlist, converter);
		} catch (Exception e) {
			return WrappedException.<T[] >wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_STDataSetRecordList toList(final TypeInformation<T> methodTypeArg_T, T[] array, Func.Func1<T, RCt_STDataSetRecord> converter) {
		try {
			RLt_STDataSetRecordList result = new RLt_STDataSetRecordList();
			result.innerFromArray(methodTypeArg_T, array, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_STDataSetRecordList>wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_STDataSetRecordList fromRestList(final TypeInformation<T> methodTypeArg_T, RestList<T> restList, Func.Func1<T, RCt_STDataSetRecord> converter) {
		try {
			RLt_STDataSetRecordList result = new RLt_STDataSetRecordList();
			result.innerFromRestList(methodTypeArg_T, restList, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_STDataSetRecordList>wrapExceptionIfNeeded(e);
		}
	}
	/**
	 *
	 * Default Constructor
	 */
	public RLt_STDataSetRecordList() {
		super(TypeInformation.get(RCt_STDataSetRecord.class));
	}

	/**
	 *
	 * Constructor with transaction parameter
	 *
	 * @param  trans
	 *         ADOTransaction Parameter
	 */
	@Deprecated
	public RLt_STDataSetRecordList(DbTransaction trans) {
		super(TypeInformation.get(RCt_STDataSetRecord.class), trans);
	}

	/**
	 *
	 * Constructor with transaction parameter and alternate read method
	 *
	 * @param  trans
	 *         ADOTransaction Parameter
	 * @param  alternateReadDBMethod
	 *         Alternate Read Method
	 */
	@Deprecated
	public RLt_STDataSetRecordList(DbTransaction trans, ReadDBMethodDelegate<RCt_STDataSetRecord> alternateReadDBMethod) {
		super(TypeInformation.get(RCt_STDataSetRecord.class), trans);
		this.alternateReadDBMethod = alternateReadDBMethod;
	}

	/**
	 *
	 * Sets the reader for serialization
	 *
	 * @param  in
	 *         Input
	 */
	public void readExternal(ObjectInput in) throws IOException, ClassNotFoundException {
		super.readExternal(in);
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] def = new BitSet[1];
		def[0] = BitSetUtils.newInstance(6, false);
		return def;
	}
	/**
	 *
	 * Create as new list
	 *
	 * @return  The new record list
	 */
	protected OSList<RCt_STDataSetRecord> newList() {
		return new RLt_STDataSetRecordList();
	}


}
