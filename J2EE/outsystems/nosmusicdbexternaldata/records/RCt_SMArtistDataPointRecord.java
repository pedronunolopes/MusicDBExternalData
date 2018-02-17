package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_SMArtistDataPointRecord implements Serializable, Cloneable, ITypedRecord<RCt_SMArtistDataPointRecord> {

	private static final GlobalObjectKey Idt_SMArtistDataPoint = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*boW0h+2kqjw4ZjANp99L2A");

	public static void ensureInitialized() {}
	public ENt_SMArtistDataPointEntityRecord ssENt_SMArtistDataPoint;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_SMArtistDataPointEntityRecord toStructure() {
		return ssENt_SMArtistDataPoint;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_SMArtistDataPointRecord(ENt_SMArtistDataPointEntityRecord r) throws Exception {
		ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_SMArtistDataPoint.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_SMArtistDataPoint.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_SMArtistDataPointRecord() {
		OptimizedAttributes = null;
		ssENt_SMArtistDataPoint = new ENt_SMArtistDataPointEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(9, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_SMArtistDataPoint.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_SMArtistDataPoint.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_SMArtistDataPoint.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_SMArtistDataPoint.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_SMArtistDataPointRecord r) throws Exception {
		this.ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord) r.ssENt_SMArtistDataPoint.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_SMArtistDataPointRecord)) {
			return false;
		}
		RCt_SMArtistDataPointRecord b = (RCt_SMArtistDataPointRecord) obj;
		if (!this.ssENt_SMArtistDataPoint.equals(b.ssENt_SMArtistDataPoint)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_SMArtistDataPoint.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_SMArtistDataPoint.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_SMArtistDataPoint.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_SMArtistDataPointRecord duplicate() throws Exception {
		RCt_SMArtistDataPointRecord t = new RCt_SMArtistDataPointRecord();
		t.ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord) this.ssENt_SMArtistDataPoint.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_SMArtistDataPoint.toXml(this, recordElem, "t_SMArtistDataPoint", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_smartistdatapoint")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_SMArtistDataPoint")) variable.setValue(ssENt_SMArtistDataPoint); else variable.setOptimized(true);
			variable.setFieldName("t_smartistdatapoint");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_SMArtistDataPointRecord t = (RCt_SMArtistDataPointRecord) super.clone();
		t.ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord) this.ssENt_SMArtistDataPoint.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_SMArtistDataPoint.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_SMArtistDataPoint.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_SMArtistDataPoint)) {
			return ssENt_SMArtistDataPoint;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_SMArtistDataPoint.fillFromOther((IRecord) other.attributeGet(Idt_SMArtistDataPoint));
	}
}
