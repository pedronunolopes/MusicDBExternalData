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


public class RCt_MDDataSetRecord implements Serializable, Cloneable, ITypedRecord<RCt_MDDataSetRecord> {

	private static final GlobalObjectKey Idt_MDDataSet = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*GLSBC5_Qwnprxu1efOuUBw");

	public static void ensureInitialized() {}
	public ENt_MDDataSetEntityRecord ssENt_MDDataSet;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MDDataSetEntityRecord toStructure() {
		return ssENt_MDDataSet;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MDDataSetRecord(ENt_MDDataSetEntityRecord r) throws Exception {
		ssENt_MDDataSet = (ENt_MDDataSetEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MDDataSet.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MDDataSet.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MDDataSetRecord() {
		OptimizedAttributes = null;
		ssENt_MDDataSet = new ENt_MDDataSetEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MDDataSet.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MDDataSet.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MDDataSet.OptimizedAttributes;
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
		index = ssENt_MDDataSet.read(r, index);
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
	public void readIM(RCt_MDDataSetRecord r) throws Exception {
		this.ssENt_MDDataSet = (ENt_MDDataSetEntityRecord) r.ssENt_MDDataSet.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MDDataSetRecord)) {
			return false;
		}
		RCt_MDDataSetRecord b = (RCt_MDDataSetRecord) obj;
		if (!this.ssENt_MDDataSet.equals(b.ssENt_MDDataSet)) return false;
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
			return super.hashCode() ^ ssENt_MDDataSet.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MDDataSet.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MDDataSet.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MDDataSetRecord duplicate() throws Exception {
		RCt_MDDataSetRecord t = new RCt_MDDataSetRecord();
		t.ssENt_MDDataSet = (ENt_MDDataSetEntityRecord) this.ssENt_MDDataSet.duplicate();
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
			ssENt_MDDataSet.toXml(this, recordElem, "t_MDDataSet", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mddataset")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MDDataSet")) variable.setValue(ssENt_MDDataSet); else variable.setOptimized(true);
			variable.setFieldName("t_mddataset");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MDDataSetRecord t = (RCt_MDDataSetRecord) super.clone();
		t.ssENt_MDDataSet = (ENt_MDDataSetEntityRecord) this.ssENt_MDDataSet.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDDataSet.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDDataSet.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MDDataSet)) {
			return ssENt_MDDataSet;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MDDataSet.fillFromOther((IRecord) other.attributeGet(Idt_MDDataSet));
	}
}
