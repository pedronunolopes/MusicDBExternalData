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


public class RCt_STDataSetRecord implements Serializable, Cloneable, ITypedRecord<RCt_STDataSetRecord> {

	private static final GlobalObjectKey Idt_STDataSet = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*m_nt8xYiCgBXbkF4s4_5Kg");

	public static void ensureInitialized() {}
	public ENt_STDataSetEntityRecord ssENt_STDataSet;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_STDataSetEntityRecord toStructure() {
		return ssENt_STDataSet;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_STDataSetRecord(ENt_STDataSetEntityRecord r) throws Exception {
		ssENt_STDataSet = (ENt_STDataSetEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_STDataSet.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_STDataSet.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_STDataSetRecord() {
		OptimizedAttributes = null;
		ssENt_STDataSet = new ENt_STDataSetEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(6, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_STDataSet.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_STDataSet.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_STDataSet.OptimizedAttributes;
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
		index = ssENt_STDataSet.read(r, index);
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
	public void readIM(RCt_STDataSetRecord r) throws Exception {
		this.ssENt_STDataSet = (ENt_STDataSetEntityRecord) r.ssENt_STDataSet.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_STDataSetRecord)) {
			return false;
		}
		RCt_STDataSetRecord b = (RCt_STDataSetRecord) obj;
		if (!this.ssENt_STDataSet.equals(b.ssENt_STDataSet)) return false;
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
			return super.hashCode() ^ ssENt_STDataSet.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_STDataSet.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_STDataSet.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_STDataSetRecord duplicate() throws Exception {
		RCt_STDataSetRecord t = new RCt_STDataSetRecord();
		t.ssENt_STDataSet = (ENt_STDataSetEntityRecord) this.ssENt_STDataSet.duplicate();
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
			ssENt_STDataSet.toXml(this, recordElem, "t_STDataSet", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_stdataset")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_STDataSet")) variable.setValue(ssENt_STDataSet); else variable.setOptimized(true);
			variable.setFieldName("t_stdataset");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_STDataSetRecord t = (RCt_STDataSetRecord) super.clone();
		t.ssENt_STDataSet = (ENt_STDataSetEntityRecord) this.ssENt_STDataSet.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_STDataSet.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_STDataSet.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_STDataSet)) {
			return ssENt_STDataSet;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_STDataSet.fillFromOther((IRecord) other.attributeGet(Idt_STDataSet));
	}
}
