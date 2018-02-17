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


public class RCt_MGPromoterContactRecord implements Serializable, Cloneable, ITypedRecord<RCt_MGPromoterContactRecord> {

	private static final GlobalObjectKey Idt_MGPromoterContact = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*WJ_PqoaeUpK5GZjtNV0LkA");

	public static void ensureInitialized() {}
	public ENt_MGPromoterContactEntityRecord ssENt_MGPromoterContact;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MGPromoterContactEntityRecord toStructure() {
		return ssENt_MGPromoterContact;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MGPromoterContactRecord(ENt_MGPromoterContactEntityRecord r) throws Exception {
		ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MGPromoterContact.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MGPromoterContact.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MGPromoterContactRecord() {
		OptimizedAttributes = null;
		ssENt_MGPromoterContact = new ENt_MGPromoterContactEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MGPromoterContact.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MGPromoterContact.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MGPromoterContact.OptimizedAttributes;
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
		index = ssENt_MGPromoterContact.read(r, index);
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
	public void readIM(RCt_MGPromoterContactRecord r) throws Exception {
		this.ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord) r.ssENt_MGPromoterContact.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MGPromoterContactRecord)) {
			return false;
		}
		RCt_MGPromoterContactRecord b = (RCt_MGPromoterContactRecord) obj;
		if (!this.ssENt_MGPromoterContact.equals(b.ssENt_MGPromoterContact)) return false;
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
			return super.hashCode() ^ ssENt_MGPromoterContact.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MGPromoterContact.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MGPromoterContact.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MGPromoterContactRecord duplicate() throws Exception {
		RCt_MGPromoterContactRecord t = new RCt_MGPromoterContactRecord();
		t.ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord) this.ssENt_MGPromoterContact.duplicate();
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
			ssENt_MGPromoterContact.toXml(this, recordElem, "t_MGPromoterContact", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mgpromotercontact")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MGPromoterContact")) variable.setValue(ssENt_MGPromoterContact); else variable.setOptimized(true);
			variable.setFieldName("t_mgpromotercontact");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MGPromoterContactRecord t = (RCt_MGPromoterContactRecord) super.clone();
		t.ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord) this.ssENt_MGPromoterContact.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGPromoterContact.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGPromoterContact.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MGPromoterContact)) {
			return ssENt_MGPromoterContact;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MGPromoterContact.fillFromOther((IRecord) other.attributeGet(Idt_MGPromoterContact));
	}
}
