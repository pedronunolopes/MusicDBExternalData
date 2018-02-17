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


public class RCt_MGPromoterRecord implements Serializable, Cloneable, ITypedRecord<RCt_MGPromoterRecord> {

	private static final GlobalObjectKey Idt_MGPromoter = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*dKj8yzhboJLqCO2fYstplA");

	public static void ensureInitialized() {}
	public ENt_MGPromoterEntityRecord ssENt_MGPromoter;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MGPromoterEntityRecord toStructure() {
		return ssENt_MGPromoter;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MGPromoterRecord(ENt_MGPromoterEntityRecord r) throws Exception {
		ssENt_MGPromoter = (ENt_MGPromoterEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MGPromoter.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MGPromoter.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MGPromoterRecord() {
		OptimizedAttributes = null;
		ssENt_MGPromoter = new ENt_MGPromoterEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(6, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MGPromoter.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MGPromoter.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MGPromoter.OptimizedAttributes;
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
		index = ssENt_MGPromoter.read(r, index);
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
	public void readIM(RCt_MGPromoterRecord r) throws Exception {
		this.ssENt_MGPromoter = (ENt_MGPromoterEntityRecord) r.ssENt_MGPromoter.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MGPromoterRecord)) {
			return false;
		}
		RCt_MGPromoterRecord b = (RCt_MGPromoterRecord) obj;
		if (!this.ssENt_MGPromoter.equals(b.ssENt_MGPromoter)) return false;
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
			return super.hashCode() ^ ssENt_MGPromoter.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MGPromoter.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MGPromoter.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MGPromoterRecord duplicate() throws Exception {
		RCt_MGPromoterRecord t = new RCt_MGPromoterRecord();
		t.ssENt_MGPromoter = (ENt_MGPromoterEntityRecord) this.ssENt_MGPromoter.duplicate();
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
			ssENt_MGPromoter.toXml(this, recordElem, "t_MGPromoter", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mgpromoter")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MGPromoter")) variable.setValue(ssENt_MGPromoter); else variable.setOptimized(true);
			variable.setFieldName("t_mgpromoter");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MGPromoterRecord t = (RCt_MGPromoterRecord) super.clone();
		t.ssENt_MGPromoter = (ENt_MGPromoterEntityRecord) this.ssENt_MGPromoter.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGPromoter.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGPromoter.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MGPromoter)) {
			return ssENt_MGPromoter;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MGPromoter.fillFromOther((IRecord) other.attributeGet(Idt_MGPromoter));
	}
}
