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
 * RecordList type <code>RLt_MUArtistCorrelationRecordList</code> that represents a record list of
 *  <code>t_MUArtistCorrelation</code>
 */
public class RLt_MUArtistCorrelationRecordList extends GenericRecordList<RCt_MUArtistCorrelationRecord> {
	public static void ensureInitialized() {}

	protected RCt_MUArtistCorrelationRecord getElementDefaultValue() {
		return new RCt_MUArtistCorrelationRecord();
	}

	public <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, Func.Func1<RCt_MUArtistCorrelationRecord, T> converter) {
		return toArray(methodTypeArg_T, this, converter);
	}

	public static <T> T[] toArray(final TypeInformation<T> methodTypeArg_T, RLt_MUArtistCorrelationRecordList recordlist, Func.Func1<RCt_MUArtistCorrelationRecord, T> converter) {
		try {
			return innerToArray(TypeInformation.get(RCt_MUArtistCorrelationRecord.class), methodTypeArg_T, recordlist, converter);
		} catch (Exception e) {
			return WrappedException.<T[] >wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_MUArtistCorrelationRecordList toList(final TypeInformation<T> methodTypeArg_T, T[] array, Func.Func1<T, RCt_MUArtistCorrelationRecord> converter) {
		try {
			RLt_MUArtistCorrelationRecordList result = new RLt_MUArtistCorrelationRecordList();
			result.innerFromArray(methodTypeArg_T, array, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_MUArtistCorrelationRecordList>wrapExceptionIfNeeded(e);
		}
	}

	public static <T> RLt_MUArtistCorrelationRecordList fromRestList(final TypeInformation<T> methodTypeArg_T, RestList<T> restList, Func.Func1<T, RCt_MUArtistCorrelationRecord> converter) {
		try {
			RLt_MUArtistCorrelationRecordList result = new RLt_MUArtistCorrelationRecordList();
			result.innerFromRestList(methodTypeArg_T, restList, converter);
			return result;
		} catch (Exception e) {
			return WrappedException.<RLt_MUArtistCorrelationRecordList>wrapExceptionIfNeeded(e);
		}
	}
	/**
	 *
	 * Default Constructor
	 */
	public RLt_MUArtistCorrelationRecordList() {
		super(TypeInformation.get(RCt_MUArtistCorrelationRecord.class));
	}

	/**
	 *
	 * Constructor with transaction parameter
	 *
	 * @param  trans
	 *         ADOTransaction Parameter
	 */
	@Deprecated
	public RLt_MUArtistCorrelationRecordList(DbTransaction trans) {
		super(TypeInformation.get(RCt_MUArtistCorrelationRecord.class), trans);
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
	public RLt_MUArtistCorrelationRecordList(DbTransaction trans, ReadDBMethodDelegate<RCt_MUArtistCorrelationRecord> alternateReadDBMethod) {
		super(TypeInformation.get(RCt_MUArtistCorrelationRecord.class), trans);
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
	protected OSList<RCt_MUArtistCorrelationRecord> newList() {
		return new RLt_MUArtistCorrelationRecordList();
	}


}
