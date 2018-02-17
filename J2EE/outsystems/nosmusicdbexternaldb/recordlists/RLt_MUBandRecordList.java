package outsystems.nosmusicdbexternaldb.recordlists;

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
import outsystems.nosmusicdbexternaldb.entities.*;
import outsystems.nosmusicdbexternaldb.structures.*;
import outsystems.nosmusicdbexternaldb.records.*;


/**
 *
 * RecordList type <code>RLt_MUBandRecordList</code> that represents a record list of
 *  <code>t_MUBand</code>
 */
public class RLt_MUBandRecordList extends GenericRecordList<RCt_MUBandRecord> {
	public static void ensureInitialized() {}

	protected RCt_MUBandRecord getElementDefaultValue() {
		return new RCt_MUBandRecord();
	}

	public <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, Func.Func1<RCt_MUBandRecord, T> converter) {
		return toArray(methodTypeArg_T, this, converter);
	}

	public static <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, RLt_MUBandRecordList recordlist, Func.Func1<RCt_MUBandRecord, T> converter) {
		try {
			return innerToArray(TypeInformation.get(RCt_MUBandRecord.class), methodTypeArg_T, recordlist, converter);
		} catch (Exception e) {
			return WrappedException.<T[] >wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_MUBandRecordList toList(final TypeInformation<T> methodTypeArg_T, T[] array, Func.Func1<T, RCt_MUBandRecord> converter) {
		try {
			RLt_MUBandRecordList result = new RLt_MUBandRecordList();
			result.innerFromArray(methodTypeArg_T, array, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_MUBandRecordList>wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_MUBandRecordList fromRestList(final TypeInformation<T> methodTypeArg_T, RestList<T> restList, Func.Func1<T, RCt_MUBandRecord> converter) {
		try {
			RLt_MUBandRecordList result = new RLt_MUBandRecordList();
			result.innerFromRestList(methodTypeArg_T, restList, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_MUBandRecordList>wrapExceptionIfNeeded(e);
		}
	}
	/**
	 *
	 * Default Constructor
	 */
	public RLt_MUBandRecordList() {
		super(TypeInformation.get(RCt_MUBandRecord.class));
	}

	/**
	 *
	 * Constructor with transaction parameter
	 *
	 * @param  trans
	 *         ADOTransaction Parameter
	 */
	@Deprecated
	public RLt_MUBandRecordList(DbTransaction trans) {
		super(TypeInformation.get(RCt_MUBandRecord.class), trans);
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
	public RLt_MUBandRecordList(DbTransaction trans, ReadDBMethodDelegate<RCt_MUBandRecord> alternateReadDBMethod) {
		super(TypeInformation.get(RCt_MUBandRecord.class), trans);
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
	protected OSList<RCt_MUBandRecord> newList() {
		return new RLt_MUBandRecordList();
	}


}
