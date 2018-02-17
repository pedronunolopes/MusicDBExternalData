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


public class RCt_MGFestivalRecord implements Serializable, Cloneable, ITypedRecord<RCt_MGFestivalRecord> {

	private static final GlobalObjectKey Idt_MGFestival = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*_YNiK7IqHG36cfpcZg8RVw");

	public static void ensureInitialized() {}
	public ENt_MGFestivalEntityRecord ssENt_MGFestival;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MGFestivalEntityRecord toStructure() {
		return ssENt_MGFestival;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MGFestivalRecord(ENt_MGFestivalEntityRecord r) throws Exception {
		ssENt_MGFestival = (ENt_MGFestivalEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MGFestival.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MGFestival.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MGFestivalRecord() {
		OptimizedAttributes = null;
		ssENt_MGFestival = new ENt_MGFestivalEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(6, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MGFestival.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MGFestival.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MGFestival.OptimizedAttributes;
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
		index = ssENt_MGFestival.read(r, index);
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
	public void readIM(RCt_MGFestivalRecord r) throws Exception {
		this.ssENt_MGFestival = (ENt_MGFestivalEntityRecord) r.ssENt_MGFestival.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MGFestivalRecord)) {
			return false;
		}
		RCt_MGFestivalRecord b = (RCt_MGFestivalRecord) obj;
		if (!this.ssENt_MGFestival.equals(b.ssENt_MGFestival)) return false;
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
			return super.hashCode() ^ ssENt_MGFestival.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MGFestival.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MGFestival.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MGFestivalRecord duplicate() throws Exception {
		RCt_MGFestivalRecord t = new RCt_MGFestivalRecord();
		t.ssENt_MGFestival = (ENt_MGFestivalEntityRecord) this.ssENt_MGFestival.duplicate();
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
			ssENt_MGFestival.toXml(this, recordElem, "t_MGFestival", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mgfestival")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MGFestival")) variable.setValue(ssENt_MGFestival); else variable.setOptimized(true);
			variable.setFieldName("t_mgfestival");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MGFestivalRecord t = (RCt_MGFestivalRecord) super.clone();
		t.ssENt_MGFestival = (ENt_MGFestivalEntityRecord) this.ssENt_MGFestival.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGFestival.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGFestival.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MGFestival)) {
			return ssENt_MGFestival;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MGFestival.fillFromOther((IRecord) other.attributeGet(Idt_MGFestival));
	}
}
