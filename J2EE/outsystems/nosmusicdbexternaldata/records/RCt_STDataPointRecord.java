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


public class RCt_STDataPointRecord implements Serializable, Cloneable, ITypedRecord<RCt_STDataPointRecord> {

	private static final GlobalObjectKey Idt_STDataPoint = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*UHoAJJnZ8kJ5znWK3WMYJA");

	public static void ensureInitialized() {}
	public ENt_STDataPointEntityRecord ssENt_STDataPoint;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_STDataPointEntityRecord toStructure() {
		return ssENt_STDataPoint;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_STDataPointRecord(ENt_STDataPointEntityRecord r) throws Exception {
		ssENt_STDataPoint = (ENt_STDataPointEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_STDataPoint.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_STDataPoint.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_STDataPointRecord() {
		OptimizedAttributes = null;
		ssENt_STDataPoint = new ENt_STDataPointEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(9, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_STDataPoint.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_STDataPoint.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_STDataPoint.OptimizedAttributes;
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
		index = ssENt_STDataPoint.read(r, index);
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
	public void readIM(RCt_STDataPointRecord r) throws Exception {
		this.ssENt_STDataPoint = (ENt_STDataPointEntityRecord) r.ssENt_STDataPoint.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_STDataPointRecord)) {
			return false;
		}
		RCt_STDataPointRecord b = (RCt_STDataPointRecord) obj;
		if (!this.ssENt_STDataPoint.equals(b.ssENt_STDataPoint)) return false;
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
			return super.hashCode() ^ ssENt_STDataPoint.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_STDataPoint.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_STDataPoint.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_STDataPointRecord duplicate() throws Exception {
		RCt_STDataPointRecord t = new RCt_STDataPointRecord();
		t.ssENt_STDataPoint = (ENt_STDataPointEntityRecord) this.ssENt_STDataPoint.duplicate();
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
			ssENt_STDataPoint.toXml(this, recordElem, "t_STDataPoint", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_stdatapoint")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_STDataPoint")) variable.setValue(ssENt_STDataPoint); else variable.setOptimized(true);
			variable.setFieldName("t_stdatapoint");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_STDataPointRecord t = (RCt_STDataPointRecord) super.clone();
		t.ssENt_STDataPoint = (ENt_STDataPointEntityRecord) this.ssENt_STDataPoint.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_STDataPoint.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_STDataPoint.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_STDataPoint)) {
			return ssENt_STDataPoint;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_STDataPoint.fillFromOther((IRecord) other.attributeGet(Idt_STDataPoint));
	}
}
